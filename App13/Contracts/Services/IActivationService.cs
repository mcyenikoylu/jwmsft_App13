﻿namespace App13.Contracts.Services;

public interface IActivationService
{
    Task ActivateAsync(object activationArgs);
}
