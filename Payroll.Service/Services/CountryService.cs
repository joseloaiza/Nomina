   namespace Payroll.Domain.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Payroll.Domain.Interfaces;
    using Payroll.Infrastructure;
    using Payroll.Models.Common;
    using Payroll.Models.Entities;

    public class CountryService : ICountryService 
    {
        private readonly IUnitOfWork _UOW;
        
        public CountryService(IUnitOfWork uow)
        {
            _UOW = uow;
        }       
       
        public async Task<Response<List<Country>>> Get()
        {
            try
            {  
                var response = new Response<List<Country>> { IsSuccess = true };
                var repo = _UOW.GetReadOnlyRepository<Country>();
                var result = repo.GetList();   
                if (result.Items != null)
                {
                    response.IsSuccess = true;
                    response.ReturnMessage = "Data found successfully";
                    response.Data = result.Items.ToList();
                    return response;
                }
                else
                {
                    response.IsSuccess = false;
                    response.ReturnMessage = "Data no found";
                    return response;
                }
            }
            catch (Exception exc)
            {
                //TODO: is necessary to implement log strategy 
                throw;
            }              
        }

        public Task<Response<Country>> Get(Guid id)
        {
            throw new NotImplementedException();
            //var repo = _UOW.GetReadOnlyRepository<Country>();
            //return repo.Search(id);
        }

        public Task<Response<string>> Create(Country entity)
        {
            throw new NotImplementedException();
            //var repo = _UOW.GetRepositoryAsync<Country>();
            //await repo.AddAsync(entity);
            //_UOW.SaveChanges();
        }

        public Task<Response<string>> Update(Country entity)
        {
            throw new NotImplementedException();
            //var repo = _UOW.GetRepositoryAsync<Country>();
            //repo.UpdateAsync(entity);
            //_UOW.SaveChanges();
        }

        public Task<Response<string>> Delete(Guid id)
        {
            throw new NotImplementedException();
            //var repo = _UOW.GetRepository<Country>();
            //repo.Delete(id);
            //_UOW.SaveChanges();
        }

        public Task<Response<bool>> Exist(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            //Dispose(true);
            //GC.SuppressFinalize(this);
        }
    }
}
