namespace CodingChallenge.DataModel.Migrations
{
    using CodingChallenge.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodingChallenge.DataModel.CodingChallengeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodingChallenge.DataModel.CodingChallengeContext context)
        {
            IList<User> users = new List<User>();
            users.Add(new User() { FirstName = "First Name User 1", LastName = "Last Name User 1" });
            users.Add(new User() { FirstName = "First Name User 2", LastName = "Last Name User 2" });
            users.Add(new User() { FirstName = "First Name User 3", LastName = "Last Name User 3" });
            context.Users.AddRange(users);

            IList<Project> projects = new List<Project>();
            projects.Add(new Project() {
                StartDate = new DateTime(2018, 5, 14, 10, 30, 0, 0),
                EndDate = new DateTime(2019, 1, 30, 18, 0, 0, 0),
                Credits = 5000
            });
            projects.Add(new Project()
            {
                StartDate = new DateTime(2018, 3, 14, 10, 30, 0, 0),
                EndDate = new DateTime(2019, 1, 30, 18, 0, 0, 0),
                Credits = 7000
            });
            projects.Add(new Project()
            {
                StartDate = new DateTime(2018, 8, 1, 8, 30, 0, 0),
                EndDate = new DateTime(2019, 10, 15, 19, 0, 0, 0),
                Credits = 10000
            });
            projects.Add(new Project()
            {
                StartDate = new DateTime(2019, 1, 10, 8, 0, 0, 0),
                EndDate = new DateTime(2019, 12, 15, 16, 30, 0, 0),
                Credits = 10000
            });
            projects.Add(new Project()
            {
                StartDate = new DateTime(2018, 12, 1, 10, 30, 0, 0),
                EndDate = new DateTime(2019, 9, 22, 18, 0, 0, 0),
                Credits = 15000
            });
            context.Projects.AddRange(projects);


            IList<UserProject> userProjects = new List<UserProject>();
            userProjects.Add(new UserProject() {
                User = users[0],
                Project = projects[0],
                IsActive = true,
                AssignedDate = new DateTime(2017, 6, 15, 10, 0, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[1],
                Project = projects[0],
                IsActive = false,
                AssignedDate = new DateTime(2018, 7, 10, 9, 45, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[2],
                Project = projects[0],
                IsActive = true,
                AssignedDate = new DateTime(2017, 10, 1, 9, 30, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[0],
                Project = projects[1],
                IsActive = true,
                AssignedDate = new DateTime(2018, 5, 2, 11, 30, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[1],
                Project = projects[2],
                IsActive = true,
                AssignedDate = new DateTime(2019, 3, 21, 14, 30, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[2],
                Project = projects[2],
                IsActive = false,
                AssignedDate = new DateTime(2019, 1, 21, 14, 30, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[1],
                Project = projects[3],
                IsActive = true,
                AssignedDate = new DateTime(2017, 3, 21, 14, 30, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[2],
                Project = projects[3],
                IsActive = true,
                AssignedDate = new DateTime(2019, 3, 20, 14, 30, 0, 0)
            });
            userProjects.Add(new UserProject()
            {
                User = users[2],
                Project = projects[4],
                IsActive = true,
                AssignedDate = new DateTime(2018, 12, 20, 15, 10, 0, 0)
            });
            context.UserProject.AddRange(userProjects);

            base.Seed(context);
        }
    }
}
