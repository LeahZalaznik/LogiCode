using AutoMapper;
using Core.DTO;
using Core.DAO;
using Data.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using task = Core.DAO.MyTask;
using TaskDto = Core.DTO.MyTask;
using Service.Interfaces;

namespace Service
{
    public class TaskService:ITaskService
    {
        private readonly IMapper _mapper;
        private readonly ITaskRepository _taskRepository;

        public TaskService(ITaskRepository repository, IMapper mapper)
        {
            _mapper = mapper;
            _taskRepository = repository;
        }

        public async Task<TaskDto> AddAsync(TaskDto taskDto)
        {
            var entity = _mapper.Map<task>(taskDto);
            var added = await _taskRepository.AddAsync(entity);
            return _mapper.Map<TaskDto>(added);
        }

        public async Task<TaskDto> UpdateAsync(TaskDto taskDto)
        {
            var entity = _mapper.Map<task>(taskDto);
            var updated = await _taskRepository.UpdateAsync(entity);
            return _mapper.Map<TaskDto>(updated);
        }

        public async Task<TaskDto> DeleteAsync(int id)
        {
            var deleted = await _taskRepository.DeleteAsync(id);
            return _mapper.Map<TaskDto>(deleted);
        }

        public async Task<List<TaskDto>> GetAllAsync()
        {
            var tasks = await _taskRepository.GetAllAsync();
                 return _mapper.Map<List<TaskDto>>(tasks);
        }

        public async Task<TaskDto> GetByIdAsync(int id)
        {
            var task = await _taskRepository.GetByIdAsync(id);
            return _mapper.Map<TaskDto>(task);
        }

       
    }
}
