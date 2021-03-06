// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;

namespace JIT.HardwareIntrinsics.Arm
{
    public static partial class Program
    {
        static Program()
        {
            TestList = new Dictionary<string, Action>() {
                ["LoadAndInsertScalar.Vector128.UInt32.3"] = LoadAndInsertScalar_Vector128_UInt32_3,
                ["LoadAndInsertScalar.Vector128.UInt64.1"] = LoadAndInsertScalar_Vector128_UInt64_1,
                ["LoadAndReplicateToVector64.Byte"] = LoadAndReplicateToVector64_Byte,
                ["LoadAndReplicateToVector64.Int16"] = LoadAndReplicateToVector64_Int16,
                ["LoadAndReplicateToVector64.Int32"] = LoadAndReplicateToVector64_Int32,
                ["LoadAndReplicateToVector64.SByte"] = LoadAndReplicateToVector64_SByte,
                ["LoadAndReplicateToVector64.Single"] = LoadAndReplicateToVector64_Single,
                ["LoadAndReplicateToVector64.UInt16"] = LoadAndReplicateToVector64_UInt16,
                ["LoadAndReplicateToVector64.UInt32"] = LoadAndReplicateToVector64_UInt32,
                ["LoadAndReplicateToVector128.Byte"] = LoadAndReplicateToVector128_Byte,
                ["LoadAndReplicateToVector128.Int16"] = LoadAndReplicateToVector128_Int16,
                ["LoadAndReplicateToVector128.Int32"] = LoadAndReplicateToVector128_Int32,
                ["LoadAndReplicateToVector128.SByte"] = LoadAndReplicateToVector128_SByte,
                ["LoadAndReplicateToVector128.Single"] = LoadAndReplicateToVector128_Single,
                ["LoadAndReplicateToVector128.UInt16"] = LoadAndReplicateToVector128_UInt16,
                ["LoadAndReplicateToVector128.UInt32"] = LoadAndReplicateToVector128_UInt32,
                ["LoadVector64.Byte"] = LoadVector64_Byte,
                ["LoadVector64.Double"] = LoadVector64_Double,
                ["LoadVector64.Int16"] = LoadVector64_Int16,
                ["LoadVector64.Int32"] = LoadVector64_Int32,
                ["LoadVector64.Int64"] = LoadVector64_Int64,
                ["LoadVector64.SByte"] = LoadVector64_SByte,
                ["LoadVector64.Single"] = LoadVector64_Single,
                ["LoadVector64.UInt16"] = LoadVector64_UInt16,
                ["LoadVector64.UInt32"] = LoadVector64_UInt32,
                ["LoadVector64.UInt64"] = LoadVector64_UInt64,
                ["LoadVector128.Byte"] = LoadVector128_Byte,
                ["LoadVector128.Double"] = LoadVector128_Double,
                ["LoadVector128.Int16"] = LoadVector128_Int16,
                ["LoadVector128.Int32"] = LoadVector128_Int32,
                ["LoadVector128.Int64"] = LoadVector128_Int64,
                ["LoadVector128.SByte"] = LoadVector128_SByte,
                ["LoadVector128.Single"] = LoadVector128_Single,
                ["LoadVector128.UInt16"] = LoadVector128_UInt16,
                ["LoadVector128.UInt32"] = LoadVector128_UInt32,
                ["LoadVector128.UInt64"] = LoadVector128_UInt64,
                ["Max.Vector64.Byte"] = Max_Vector64_Byte,
                ["Max.Vector64.Int16"] = Max_Vector64_Int16,
                ["Max.Vector64.Int32"] = Max_Vector64_Int32,
                ["Max.Vector64.SByte"] = Max_Vector64_SByte,
                ["Max.Vector64.Single"] = Max_Vector64_Single,
                ["Max.Vector64.UInt16"] = Max_Vector64_UInt16,
                ["Max.Vector64.UInt32"] = Max_Vector64_UInt32,
                ["Max.Vector128.Byte"] = Max_Vector128_Byte,
                ["Max.Vector128.Int16"] = Max_Vector128_Int16,
                ["Max.Vector128.Int32"] = Max_Vector128_Int32,
                ["Max.Vector128.SByte"] = Max_Vector128_SByte,
                ["Max.Vector128.Single"] = Max_Vector128_Single,
                ["Max.Vector128.UInt16"] = Max_Vector128_UInt16,
                ["Max.Vector128.UInt32"] = Max_Vector128_UInt32,
                ["MaxNumber.Vector64.Single"] = MaxNumber_Vector64_Single,
                ["MaxNumber.Vector128.Single"] = MaxNumber_Vector128_Single,
                ["MaxNumberScalar.Vector64.Double"] = MaxNumberScalar_Vector64_Double,
                ["MaxNumberScalar.Vector64.Single"] = MaxNumberScalar_Vector64_Single,
                ["MaxPairwise.Vector64.Byte"] = MaxPairwise_Vector64_Byte,
                ["MaxPairwise.Vector64.Int16"] = MaxPairwise_Vector64_Int16,
                ["MaxPairwise.Vector64.Int32"] = MaxPairwise_Vector64_Int32,
                ["MaxPairwise.Vector64.SByte"] = MaxPairwise_Vector64_SByte,
                ["MaxPairwise.Vector64.Single"] = MaxPairwise_Vector64_Single,
                ["MaxPairwise.Vector64.UInt16"] = MaxPairwise_Vector64_UInt16,
                ["MaxPairwise.Vector64.UInt32"] = MaxPairwise_Vector64_UInt32,
                ["Min.Vector64.Byte"] = Min_Vector64_Byte,
                ["Min.Vector64.Int16"] = Min_Vector64_Int16,
                ["Min.Vector64.Int32"] = Min_Vector64_Int32,
                ["Min.Vector64.SByte"] = Min_Vector64_SByte,
                ["Min.Vector64.Single"] = Min_Vector64_Single,
                ["Min.Vector64.UInt16"] = Min_Vector64_UInt16,
                ["Min.Vector64.UInt32"] = Min_Vector64_UInt32,
                ["Min.Vector128.Byte"] = Min_Vector128_Byte,
                ["Min.Vector128.Int16"] = Min_Vector128_Int16,
                ["Min.Vector128.Int32"] = Min_Vector128_Int32,
                ["Min.Vector128.SByte"] = Min_Vector128_SByte,
                ["Min.Vector128.Single"] = Min_Vector128_Single,
                ["Min.Vector128.UInt16"] = Min_Vector128_UInt16,
                ["Min.Vector128.UInt32"] = Min_Vector128_UInt32,
                ["MinNumber.Vector64.Single"] = MinNumber_Vector64_Single,
                ["MinNumber.Vector128.Single"] = MinNumber_Vector128_Single,
                ["MinNumberScalar.Vector64.Double"] = MinNumberScalar_Vector64_Double,
                ["MinNumberScalar.Vector64.Single"] = MinNumberScalar_Vector64_Single,
                ["MinPairwise.Vector64.Byte"] = MinPairwise_Vector64_Byte,
                ["MinPairwise.Vector64.Int16"] = MinPairwise_Vector64_Int16,
                ["MinPairwise.Vector64.Int32"] = MinPairwise_Vector64_Int32,
                ["MinPairwise.Vector64.SByte"] = MinPairwise_Vector64_SByte,
                ["MinPairwise.Vector64.Single"] = MinPairwise_Vector64_Single,
                ["MinPairwise.Vector64.UInt16"] = MinPairwise_Vector64_UInt16,
                ["MinPairwise.Vector64.UInt32"] = MinPairwise_Vector64_UInt32,
                ["Multiply.Vector64.Byte"] = Multiply_Vector64_Byte,
                ["Multiply.Vector64.Int16"] = Multiply_Vector64_Int16,
                ["Multiply.Vector64.Int32"] = Multiply_Vector64_Int32,
                ["Multiply.Vector64.SByte"] = Multiply_Vector64_SByte,
                ["Multiply.Vector64.Single"] = Multiply_Vector64_Single,
                ["Multiply.Vector64.UInt16"] = Multiply_Vector64_UInt16,
                ["Multiply.Vector64.UInt32"] = Multiply_Vector64_UInt32,
                ["Multiply.Vector128.Byte"] = Multiply_Vector128_Byte,
                ["Multiply.Vector128.Int16"] = Multiply_Vector128_Int16,
                ["Multiply.Vector128.Int32"] = Multiply_Vector128_Int32,
                ["Multiply.Vector128.SByte"] = Multiply_Vector128_SByte,
                ["Multiply.Vector128.Single"] = Multiply_Vector128_Single,
                ["Multiply.Vector128.UInt16"] = Multiply_Vector128_UInt16,
                ["Multiply.Vector128.UInt32"] = Multiply_Vector128_UInt32,
            };
        }
    }
}
