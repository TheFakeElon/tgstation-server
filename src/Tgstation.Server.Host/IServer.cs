﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Tgstation.Server.Host
{
	/// <summary>
	/// Represents the host
	/// </summary>
	public interface IServer : IDisposable
	{
		/// <summary>
		/// Runs the <see cref="IServer"/>
		/// </summary>
		/// <param name="args">The arguments for the <see cref="IServer"/></param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task RunAsync(string[] args, CancellationToken cancellationToken);
	}
}
