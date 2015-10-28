﻿
using System.Threading.Tasks;

namespace Soloco.ReactiveStarterKit.Common.Infrastructure.Commands
{
    public interface IHandleMessage<in TMessage, TResult> where TMessage : IMessage<TResult>
    {
        Task<TResult> Handle(TMessage command);
    }
}