using BusinessLogicLayer.GenericRepository;
using EntityLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class DepartmanServis
    {
        private DepartmanRepository departmanRepository;

        public DepartmanServis()
        {
            departmanRepository = new DepartmanRepository();
        }

        public List<DepartmanDTO> DepartmanlariGetir()
        {
            return departmanRepository.DepartmanlariGetir()
                .Select(d => new DepartmanDTO
                {
                    DepartmanID = d.ID,
                    DepartmanAd = d.DepartmanAd
                })
                .ToList();
        }
    }
}
