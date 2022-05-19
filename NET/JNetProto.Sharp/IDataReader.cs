﻿using System;

namespace JNetProto.Sharp
{
    public interface IDataReader : IDisposable
    {
        byte ReadU8();
        sbyte ReadI8();
        short ReadI16();
        int ReadI32();
        long ReadI64();
        float ReadF32();
        double ReadF64();
        decimal ReadF128();
        string ReadUtf8();
        TimeSpan ReadDuration();
        DateTime ReadTimestamp();
        Guid ReadGuid();
        object ReadObject();
    }
}