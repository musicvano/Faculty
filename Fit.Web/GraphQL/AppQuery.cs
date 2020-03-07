using Fit.Data;
using Fit.GraphQL.Types;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fit.GraphQL
{
    public class AppQuery : ObjectGraphType
    {
        public AppQuery(DataContext data)
        {
            Field<DegreeType>(
                "degree",
                arguments: new QueryArguments(new List<QueryArgument> {
                                new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the degree" }
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return data.Degrees.FirstOrDefault(d => d.Id == id);
                }
            );

            Field<ListGraphType<DegreeType>>(
                "degrees",
                resolve: context =>
                {
                    return data.Degrees.ToList();
                }
            );

            Field<RankType>(
                "rank",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the rank" }
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return data.Ranks.FirstOrDefault(r => r.Id == id);
                }
            );

            Field<ListGraphType<RankType>>(
                "ranks",
                resolve: context =>
                {
                    return data.Ranks.ToList();
                }
            );

            Field<PositionType>(
                "position",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the position" }
                }),
                resolve: context =>
                {
                    return data.Positions.ToList();
                }
            );

            Field<ListGraphType<PositionType>>(
                "positions",
                resolve: context =>
                {
                    return data.Positions.ToList();
                }
            );

            Field<FacultyType>(
                "faculty",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the faculty" }
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return data.Faculties.Include(f => f.Departments).FirstOrDefault(f => f.Id == id);
                }
            );

            Field<ListGraphType<FacultyType>>(
                "faculties",
                resolve: context =>
                {
                    return data.Faculties.Include(f => f.Departments).ToList();
                }
            );

            Field<DepartmentType>(
                "department",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the department" }
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return data.Departments.FirstOrDefault(d => d.Id == id);
                }
            );

            Field<ListGraphType<DepartmentType>>(
                "departments",
                resolve: context =>
                {
                    return data.Departments.ToList();
                }
            );

            Field<GroupType>(
                "group",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the group" }
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return data.Groups.FirstOrDefault(g => g.Id == id);
                }
            );

            Field<ListGraphType<GroupType>>(
                "groups",
                resolve: context =>
                {
                    return data.Groups.Include(g => g.Students).Include(g => g.Faculty).ToList();
                }
            );

            Field<StudentType>(
                "student",
                arguments: new QueryArguments(new List<QueryArgument> {
                    new QueryArgument<IdGraphType> { Name = "id", Description = "The ID of the student" }
                }),
                resolve: context =>
                {
                    var id = context.GetArgument<Guid>("id");
                    return data.Students.FirstOrDefault(g => g.Id == id);
                }
            );

            Field<ListGraphType<StudentType>>(
                "students",
                resolve: context =>
                {
                    return data.Students
                        .Include(s => s.Country)
                        .Include(s => s.Region)
                        .Include(s => s.Region)
                        .Include(s => s.City)
                        .Include(s => s.Funding)
                        .Include(s => s.Study)
                        .Include(s => s.Status)
                        .Include(s => s.Group)
                        .Include(s => s.Specialty)
                        .ToList();
                }
            );
        }
    }
}