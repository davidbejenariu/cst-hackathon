using backend.backend_BLL.Interfaces;
using backend.backend_BLL.Models;
using backend.backend_DAL.Entities;
using backend.backend_DAL.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Net.Mail;

namespace backend.backend_BLL.Services
{
    public class CodeService : ICodeService
    {
        private readonly ICodeRepository _codeRepository;

        public CodeService(ICodeRepository codeRepository)
        {
            _codeRepository = codeRepository;
        }

        public async Task Create(CodeModel code)
        {

            var newCode = new Code
            {
                Id = new Guid(),
                Name = code.Content,
                ProductId = code.ProductId,
                IsUsed = false,
                // am mai fi avut product...
                // de completat aici cum creeam un code dupa model i guess de vazut
                /*                Date = DateTime.Now,
                                Type = test.Type,
                                Result = test.Result,
                                DoctorId = test.DoctorId,
                                PatientId = test.PatientId,
                                DonorId = test.DonorId,*/

            };

            await _codeRepository.Create(newCode);

        }
        public async Task<List<Guid>> GetCodes()
        {
            var codes = await _codeRepository.GetAllCodes();
            var list = new List<Guid>();
            foreach (var code in codes)
            {
                list.Add(code.Id);
            }
            return list;

        }
    }
}