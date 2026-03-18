using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete_DAL.Repository;
using EntityLayer.Concrete_Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Concrete_DAL.EntityFramework
{
    public class EFLocationDAL : GenericRepository<Location> , ILocationDAL
    {
    }
}
