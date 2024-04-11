using SegurosFYP.Common.Models;
using SegurosFYP.Models;
using SegurosFYP.WebAPI;
using SegurosFYP_WEB.Models;
using SegurosFYP_WEB.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SegurosFYP.Services
{
    public class PersonaServices
    {
        private readonly API _api;

        public PersonaServices(API api)
        {
            _api = api;
        }

        public async Task<ServiceResult> Insert(PersonaViewModel item)
        {
            var result = new ServiceResult();
            try
            {
                var response = await _api.Post<PersonaViewModel, ServiceResult>(req =>
                {
                    req.Path = $"/persona/Insert";
                    req.Content = item;
                });
                if (!response.Success)
                {
                    return result.FromApi(response);
                }
                else
                {
                    return result.Ok(response.Data);

                }
            }
            catch (Exception ex)
            {
                return result.Error(Helpers.GetMessage(ex));
                throw;
            }
        }
    }
}
