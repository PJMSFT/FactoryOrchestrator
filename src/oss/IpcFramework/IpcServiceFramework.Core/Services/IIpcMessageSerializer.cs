﻿namespace JKang.IpcServiceFramework
{
    public interface IIpcMessageSerializer
    {
        byte[] SerializeRequest(IpcRequest request);
        IpcResponse DeserializeResponse(byte[] binary);
        IpcRequest DeserializeRequest(byte[] binary);
        byte[] SerializeResponse(IpcResponse response);
    }
}
