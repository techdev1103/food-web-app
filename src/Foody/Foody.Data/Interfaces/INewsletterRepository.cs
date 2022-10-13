﻿namespace Foody.Data.Interfaces;

public interface INewsletterRepository : IRepository<Newsletter>
{
    bool Duplicate(string email);
}

