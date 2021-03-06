﻿using System.Reflection;

namespace Amido.NAuto.Builders.Services
{
    public class PopulateByteService : PopulateProperty<byte>
    {
        public override byte Populate(string propertyName, byte currentValue, PropertyInfo propertyInfo = null)
        {
            return currentValue == default(byte) ? GetByteValue(propertyName) : currentValue;
        }

        private byte GetByteValue(string propertyName)
        {
            if (AutoBuilderConfiguration.Conventions.MatchesConvention(propertyName, typeof(byte)))
            {
                return (byte)AutoBuilderConfiguration.Conventions.GetConventionResult(propertyName, typeof(byte), AutoBuilderConfiguration);
            }
            return (byte)NAuto.GetRandomInteger(1, 1000);
        }
    }
}
