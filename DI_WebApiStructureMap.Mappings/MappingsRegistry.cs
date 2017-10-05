using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using DI_WebApiStructureMap.DAL.Repositories;
using DI_WebApiStructureMap.MemoryStore;
using StructureMap;
using StructureMap.Pipeline;

namespace DI_WebApiStructureMap.Mappings
{
    public class MappingsRegistry : Registry
    {
        public MappingsRegistry()
        {
            For<IMovieRepository>().Use<MovieRepository>().LifecycleIs<UniquePerRequestLifecycle>();
        }
    }
}
