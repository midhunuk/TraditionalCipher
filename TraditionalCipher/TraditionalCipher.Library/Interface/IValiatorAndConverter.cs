using System;

namespace TraditionalCipher.Library.Interface
{
    public interface IValiatorAndConverter
    {
        string ValidateAndConvert(string text, InputType inputType, Func<int,int,int> shfitFuction);
    }
}
