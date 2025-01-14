﻿using Content.Server.ParticleAccelerator.Components;
using Content.Server.Power.EntitySystems;
using JetBrains.Annotations;
using Robust.Shared.GameObjects;

namespace Content.Server.ParticleAccelerator.EntitySystems
{
    public sealed partial class ParticleAcceleratorSystem
    {
        private void InitializePowerBoxSystem()
        {
            SubscribeLocalEvent<ParticleAcceleratorPowerBoxComponent, PowerConsumerReceivedChanged>(PowerBoxReceivedChanged);
        }

        private static void PowerBoxReceivedChanged(
            EntityUid uid,
            ParticleAcceleratorPowerBoxComponent component,
            PowerConsumerReceivedChanged args)
        {
            component.Master?.PowerBoxReceivedChanged(args);
        }
    }
}
