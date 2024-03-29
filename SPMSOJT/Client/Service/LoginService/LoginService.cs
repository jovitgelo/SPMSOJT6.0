﻿using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace SPMSOJT.Client.Service.LoginService
{
    public class LoginService : ILoginService
    {
        private readonly HttpClient _http;

        public LoginService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Coordinator> GetCoordinator(string email)
        {
            var result = await _http.GetFromJsonAsync<Coordinator>($"api/login/coordinator/{email}");
            return result;
        }

        public async Task<Supervisor> GetSupervisor(string email)
        {
            var result = await _http.GetFromJsonAsync<Supervisor>($"api/login/supervisor/{email}");
            return result;
        }

        public async Task<User> GetUser(string email)
        {
            var result = await _http.GetFromJsonAsync<User>($"api/login/user/{email}");
            return result;
        }

        public async Task<Coordinator> LoginCoordinator(LoginToken LoginCoordinator)
        {
            var result = await _http.PostAsJsonAsync("api/login/coordinator", LoginCoordinator);
            var status = await result.Content.ReadFromJsonAsync<Coordinator>();
            return status;
        }

        public async Task<Supervisor> LoginSupervisor(LoginToken LoginSupervisor)
        {
            var result = await _http.PostAsJsonAsync("api/login/supervisor", LoginSupervisor);
            var status = await result.Content.ReadFromJsonAsync<Supervisor>();
            return status;
        }

        public async Task<User> LoginUser(LoginToken LoginUser)
        {
            var result = await _http.PostAsJsonAsync("api/login/user", LoginUser);
            var status = await result.Content.ReadFromJsonAsync<User>();
            return status;
        }
    }
}
