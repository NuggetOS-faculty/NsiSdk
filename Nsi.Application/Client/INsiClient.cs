﻿using NsiSDK.Dto;

namespace NSISDK.Application.Models;

public interface INsiClient
{
    public Task<NsiCreatePostResponseDto> CreateProductAsync(PostProductCreateResposeModel request);
}