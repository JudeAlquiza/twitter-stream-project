﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace Data
{
    public partial class TwitterStreamDbContext
    {
        private ITwitterStreamDbContextProcedures _procedures;

        public virtual ITwitterStreamDbContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new TwitterStreamDbContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public ITwitterStreamDbContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SpGetTop10HashTagsByHourWindowResult>().HasNoKey().ToView(null);
        }
    }

    public partial class TwitterStreamDbContextProcedures : ITwitterStreamDbContextProcedures
    {
        private readonly TwitterStreamDbContext _context;

        public TwitterStreamDbContextProcedures(TwitterStreamDbContext context)
        {
            _context = context;
        }

        public virtual async Task<List<SpGetTop10HashTagsByHourWindowResult>> SpGetTop10HashTagsByHourWindowAsync(int? hourWindow, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "hourWindow",
                    Value = hourWindow ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<SpGetTop10HashTagsByHourWindowResult>("EXEC @returnValue = [dbo].[SpGetTop10HashTagsByHourWindow] @hourWindow", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
