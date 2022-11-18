﻿using Microsoft.EntityFrameworkCore;
using WebApi.Models.Entitys;

namespace WebApi.Contexts
{
    public class SqlDataContext : DbContext
    {
        public SqlDataContext(DbContextOptions<SqlDataContext> options) : base(options)
        {
        }

        public DbSet<StatusEntity> Statuses { get; set; }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<IssueEntity> Issues { get; set; }
        public DbSet<CommentEntity> Comments { get; set; }
    }
}
