﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Persistance
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}
