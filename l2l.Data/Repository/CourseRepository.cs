using System;
using l2l.Data.Model;

namespace l2l.Data.Repository
{
    public class CourseRepository
    {
        private readonly L2lDbContext db;

        public CourseRepository()
        {
            // TODO: Antipattern
            var factory= new L2lDbContextFactory();
            db = factory.CreateDbContext(new string[] {});
        }
        public void Add(Course entity)
        {
            //TODO: Async fvként hogy kellene megírni
            db.Courses.Add(entity);
            
        }
        public Course GetById(int Id)
        {
            //TODO: Async fvként hogy kellene megírni
           return db.Courses.Find(Id);
        }
    }
}