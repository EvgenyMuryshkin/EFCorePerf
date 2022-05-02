using crosscutting.sql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace transactions.sql
{
    public class TransactionsDbContextDesignFactory : AbstractContextDesignFactory<txnTransactionsDBContext>
    {
        public override txnTransactionsDBContext CreateDbContext(Guid platformId, params string[] args)
            => InternalCreateDbContext(
                platformId,
                "Data Source=.\\SQLEXPRESS;Initial catalog=transactions;Integrated Security=False;User ID=scms;Password=scms;",
                txnTransactionsDBContext.SchemaName,
                args);
    }
}
