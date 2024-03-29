﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SPMSOJT.Server.Service.TasksService;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        List<Tasks> AllTasks = new List<Tasks>();
        Tasks task = new Tasks();

        [HttpPost("create")]
        public async Task<ActionResult<List<Tasks>>> AddTasks(Tasks task)
        {
            return AllTasks = await _taskService.AddTasks(task);
        }

        [HttpPost("update")]
        public async Task<ActionResult<List<Tasks>>> UpdateTasks(Tasks task)
        {
            return AllTasks = await _taskService.UpdateTasks(task);
        }

        [HttpPost("delete")]
        public async Task<ActionResult<List<Tasks>>> DeleteTasks(Tasks task)
        {
            return AllTasks = await _taskService.RemoveTasks(task);
        }

        [HttpGet("displayall")]
        public async Task<ActionResult<List<Tasks>>> GetAllTasks()
        {
            return AllTasks = await _taskService.LoadAllTasks();
        }

        [HttpGet("displayallntask/{Id:int}")]
        public async Task<ActionResult<List<Tasks>>> GetAllNotComplyTask(int Id)
        {
            return AllTasks = await _taskService.LoadAllNotComplyTask(Id);
        }

        [HttpGet("displaytaskpersupervisor/{Id:int}")]
        public async Task<ActionResult<List<Tasks>>> GetAllTaskPerSupervisor(int Id)
        {
            return AllTasks = await _taskService.LoadAllTaskPerSupervisor(Id);
        }

        [HttpGet("displaytaskperstudent/{Id:int}")]
        public async Task<ActionResult<List<Tasks>>> GetAllTaskPerStudent(int Id)
        {
            return AllTasks = await _taskService.LoadAllTaskPerStudent(Id);
        }

        [HttpGet("display/{Id:int}")]
        public async Task<ActionResult<Tasks>> GetTask(int Id)
        {
            return task = await _taskService.GetTasks(Id);
        }
    }
}
