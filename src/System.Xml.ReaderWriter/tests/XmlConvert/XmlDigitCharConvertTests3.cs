// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using OLEDB.Test.ModuleCore;

namespace System.Xml.Tests
{
    internal class XmlDigitCharConvertTests3 : XmlDigitCharConvertTests
    {
        #region Constructors and Destructors

        public XmlDigitCharConvertTests3()
        {
            for (int i = 0; i < _byte_Digit.Length; i = i + 2)
            {
                AddVariation(new CVariation(this, "EncodeName-DecodeName : " + _Expbyte_Digit[i / 2], XmlEncodeName3));
            }
        }

        #endregion

        #region Public Methods and Operators

        public int XmlEncodeName3()
        {
            int i = ((CurVariation.id) - 1) * 2;
            string strDeVal = String.Empty;
            string strEnVal = String.Empty;
            string strVal = String.Empty;

            strVal = (BitConverter.ToChar(_byte_Digit, i)).ToString();
            strEnVal = XmlConvert.EncodeName(strVal);
            CError.Compare(strEnVal, _Expbyte_Digit[i / 2], "Encode Comparison failed at " + i);

            strDeVal = XmlConvert.DecodeName(strEnVal);
            CError.Compare(strDeVal, strVal, "Decode Comparison failed at " + i);
            return TEST_PASS;
        }
        #endregion
    }
}