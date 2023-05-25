﻿using ProfilerIntegration.Entities;

namespace ProfilerModels.Abstractions;
public interface IMessageBroker
{
    Task PublishProfileUpdatedEvent(ProfileUpdatedEvent profileUpdatedEvent);
}