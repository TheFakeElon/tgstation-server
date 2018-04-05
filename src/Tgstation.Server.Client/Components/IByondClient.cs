﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Tgstation.Server.Api.Models;
using Tgstation.Server.Api.Rights;

namespace Tgstation.Server.Client.Components
{
	/// <summary>
	/// For managing the <see cref="Byond"/> installation
	/// </summary>
	public interface IByondClient : IRightsClient<ByondRights>
	{
		/// <summary>
		/// Get the <see cref="Byond"/> represented by the <see cref="IByondClient"/>
		/// </summary>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task{TResult}"/> resulting in the <see cref="Byond"/> represented by the <see cref="IByondClient"/></returns>
		Task<Byond> Read(CancellationToken cancellationToken);

		/// <summary>
		/// Updates the installed BYOND <see cref="Version"/>
		/// </summary>
		/// <param name="byond">The <see cref="Byond"/> to update</param>
		/// <param name="progressCallback">Optional <see cref="Action{T1}"/> taking a <see cref="ByondStatus"/> to run when it changes</param>
		/// <param name="cancellationToken">The <see cref="CancellationToken"/> for the operation</param>
		/// <returns>A <see cref="Task"/> representing the running operation</returns>
		Task Update(Byond byond, Action<ByondStatus> progressCallback, CancellationToken cancellationToken);
	}
}
