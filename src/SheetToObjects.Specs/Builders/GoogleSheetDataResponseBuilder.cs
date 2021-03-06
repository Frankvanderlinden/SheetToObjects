﻿using SheetToObjects.Adapters.GoogleSheets;
using System.Collections.Generic;

namespace SheetToObjects.Specs.Builders
{
    internal class GoogleSheetDataResponseBuilder
    {
        private readonly List<List<string>> _values = new List<List<string>>();

        public GoogleSheetDataResponseBuilder WithRow(List<string> row)
        {
            _values.Add(row);
            return this;
        }

        public GoogleSheetResponse Build()
        {
            return new GoogleSheetResponse
            {
                Values = _values
            };
        }
    }
}
