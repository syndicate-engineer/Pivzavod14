// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Conchelle <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 GoobBot <uristmchands@proton.me>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 Sara Aldrete's Top Guy <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Goobstation.Common.JoinQueue;

namespace Content.Goobstation.Server.IoC;

internal static class ServerGoobContentIoC
{
    internal static void Register()
    {
        var instance = IoCManager.Instance!;

        // Register Goobstation-specific managers
        instance.Register(typeof(Redial.RedialManager));
        instance.Register(typeof(Polls.PollManager));
        instance.Register(typeof(IJoinQueueManager), typeof(JoinQueue.JoinQueueManager));
    }
}
