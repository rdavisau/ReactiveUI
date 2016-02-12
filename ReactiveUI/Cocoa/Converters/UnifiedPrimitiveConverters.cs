using System;

namespace ReactiveUI
{
    public class IntToNintConverter : IBindingTypeConverter
    {
        public int GetAffinityForObjects(Type fromType, Type toType)
        {
            return (fromType == typeof(int) && toType == typeof(nint)) ||
                (toType == typeof(int) && fromType == typeof(nint)) ? 100 : -1;
        }

        public bool TryConvert(object val, Type toType, object conversionHint, out object result)
        {
            if (val is int && toType == typeof(nint)) {
                var asInt = (int) val;
                result = (nint) asInt;

                return true;
            }
            else if (val is nint && toType == typeof(int)) {
                var asNint = (nint) val;
                result = (int) asNint;

                return true;
            }

            result = null;
            return false;
        }
    }

    public class UIntToNuintConverter : IBindingTypeConverter
    {
        public int GetAffinityForObjects(Type fromType, Type toType)
        {
            return (fromType == typeof(uint) && toType == typeof(nuint)) ||
                (toType == typeof(uint) && fromType == typeof(nuint)) ? 100 : -1;
        }

        public bool TryConvert(object val, Type toType, object conversionHint, out object result)
        {
            if (val is uint && toType == typeof(nuint)) {
                var asUint = (uint) val;
                result = (nuint) asUint;

                return true;
            }
            else if (val is nuint && toType == typeof(uint)) {
                var asNuint = (nuint)val;
                result = (uint) asNuint;

                return true;
            }

            result = null;
            return false;
        }
    }

    public class FloatToNfloatConverter : IBindingTypeConverter
    {
        public int GetAffinityForObjects(Type fromType, Type toType)
        {
            return (fromType == typeof(float) && toType == typeof(nfloat)) ||
                (toType == typeof(float) && fromType == typeof(nfloat)) ? 100 : -1;
        }

        public bool TryConvert(object val, Type toType, object conversionHint, out object result)
        {
            if (val is float && toType == typeof(nfloat)) {
                var asFloat = (float) val;
                result = (nfloat) asFloat;

                return true;
            }
            else if (val is nfloat && toType == typeof(float)) {
                var asNfloat = (nfloat) val;
                result = (float) asNfloat;

                return true;
            }

            result = null;
            return false;
        }
    }
}

