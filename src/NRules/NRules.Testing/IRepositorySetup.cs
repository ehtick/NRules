﻿using NRules.Fluent;
using NRules.Fluent.Dsl;

namespace NRules.Testing;

public interface IRepositorySetup
{
    void Rule<T>() where T : Rule;

    void Rule(IRuleMetadata metadata);
}
