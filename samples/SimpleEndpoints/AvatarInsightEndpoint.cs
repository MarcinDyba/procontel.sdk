﻿using System.Threading.Tasks;
using ProconTel.Sdk.Attributes;
using ProconTel.Sdk.Avatars;
using ProconTel.Sdk.Builders;
using ProconTel.Sdk.Services;

namespace SimpleEndpoints
{
  [EndpointMetadata(Name = "Avatar Insight Endpoint", SupportedRoles = SupportedRoles.None)]
  class AvatarInsightEndpoint : IAvatarsInsight
  {
    private ILogger Logger;

    public AvatarInsightEndpoint(ILogger logger)
    {
      Logger = logger;
    }

    public Task AvatarConnectedAsync(IAvatarConfiguration avatarConfiguration)
    {
      Logger.Information($"Avatar has been connected");
      return Task.CompletedTask;
    }

    public Task AvatarDisconnectedAsync(IAvatarConfiguration avatarConfiguration)
    {
      Logger.Information($"Avatar has been disconnected");
      return Task.CompletedTask;
    }
  }
}
