﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;

namespace PickupBot.Data.Repositories
{
    public interface IAzureTableStorage<T> where T : TableEntity
    {
        Task<List<T>> GetList();
        Task<List<T>> GetList(string partitionKey);
        Task<T> GetItem(string partitionKey, string rowKey);
        Task<bool> Insert(T item);
        Task<bool> Update(T item);
        Task<bool> Delete(string partitionKey, string rowKey);
        Task<bool> Delete(T item);
    }
}
