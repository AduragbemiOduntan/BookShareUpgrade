﻿using BookShare.Common.Dto.Request;

namespace BookShare.Common.Dto.Response;

public record RequestResponseDto
{
    public string RequestId {  get; init; }
    public bool IsReceived { get; init; }
    public bool IsDelivered { get; init; }
    public bool IsPickUp { get; init; }
    public string LocationId { get; init; }
    public ICollection<BookResponseDto> Books { get; init; }
}
