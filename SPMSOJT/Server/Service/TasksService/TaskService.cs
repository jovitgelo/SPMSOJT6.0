﻿using Microsoft.EntityFrameworkCore;
using SPMSOJT.Server.Data;
using SPMSOJT.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPMSOJT.Server.Service.TasksService
{
    public class TaskService : ITaskService
    {
        private readonly DataContext _data;

        public TaskService(DataContext data)
        {
            _data = data;
        }

        List<Tasks> AllTasks = new List<Tasks>();
        Tasks task = new Tasks();

        public async Task<List<Tasks>> AddTasks(Tasks task)
        {
            await _data.task_info.AddAsync(task);
            await _data.SaveChangesAsync();
            return AllTasks = await _data.task_info.ToListAsync();
        }

        public async Task<Tasks> GetTasks(int taskId)
        {
            return task = await _data.task_info.Where(t => t.Id == taskId).FirstOrDefaultAsync();
        }

        public async Task<List<Tasks>> LoadAllTasks()
        {
            return AllTasks = await _data.task_info.ToListAsync();
        }

        public async Task<List<Tasks>> RemoveTasks(Tasks task)
        {
            var DbCompiledTask = await _data.c_task_info.Where(c => c.TaskId == task.Id).ToListAsync();
            foreach (var dbtask in DbCompiledTask)
            {
                _data.c_task_info.Remove(dbtask);
            }
            _data.task_info.Remove(task);
            await _data.SaveChangesAsync();
            AllTasks = await _data.task_info.ToListAsync();
            return AllTasks;
        }

        public async Task<List<Tasks>> UpdateTasks(Tasks task)
        {
            AllTasks = await _data.task_info.ToListAsync();
            var dbTask = await _data.task_info.FindAsync(task.Id);
            if (dbTask != null)
            {
                _data.Entry(dbTask).CurrentValues.SetValues(task);
                await _data.SaveChangesAsync();
            }
            return AllTasks;
        }

        public async Task<List<Tasks>> LoadAllNotComplyTask(int userId)
        {
            var dbCompiledTask = await _data.c_task_info.Where(c => c.StudentId == userId).ToListAsync();
            var dbTask = await _data.task_info.ToListAsync();
            foreach (var task in dbTask)
            {
                var getTask = dbCompiledTask.Where(c => c.TaskId == task.Id).FirstOrDefault();
                if (getTask == null)
                {
                    AllTasks.Add(task);
                }
            }
            return AllTasks;
        }

        public async Task<List<Tasks>> LoadAllTaskPerSupervisor(int supervisorId)
        {
            return AllTasks = await _data.task_info.Where(t => t.SupervisorId == supervisorId).ToListAsync();
        }

        public async Task<List<Tasks>> LoadAllTaskPerStudent(int studentId)
        {
            var trainee = await _data.trainee_info.Where(t => t.studentId == studentId).FirstOrDefaultAsync();
            var dbCompiledTask = await _data.c_task_info.Where(c => c.StudentId == studentId).ToListAsync();
            var dbTask = await _data.task_info.Where(t => t.SupervisorId == trainee.supervisorId).ToListAsync();

            foreach (var task in dbTask)
            {
                var getTask = dbCompiledTask.Where(c => c.TaskId == task.Id).FirstOrDefault();
                if (getTask == null)
                {
                    AllTasks.Add(task);
                }
            }
            return AllTasks;
        }

        //GetStudentTask
        //Add supervisorid to the task and compiled task
        //Get the supervisor of the user in the trainee
        //Get all the task where supervisorid in the task is equal
        //supervisor of the user
    }
}
