﻿namespace DDD.Domain.Customers;

public class Customer
{
    public CustomerId Id { get; set; }

    public string Email { get; private set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
}
