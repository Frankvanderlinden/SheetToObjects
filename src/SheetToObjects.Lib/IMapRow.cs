﻿using System.Collections.Generic;
using CSharpFunctionalExtensions;
using SheetToObjects.Lib.Configuration;

namespace SheetToObjects.Lib
{
    internal interface IMapRow
    {
        Result<T, List<IValidationError>> Map<T>(Row row, MappingConfig mappingConfig) where T : new();
    }
}