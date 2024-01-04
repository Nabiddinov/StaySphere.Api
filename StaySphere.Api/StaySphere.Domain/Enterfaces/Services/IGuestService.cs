﻿using StaySphere.Domain.DTOs.Guest;

namespace StaySphere.Domain.Enterfaces.Services
{
    public interface IGuestService
    {
        Task<GuestDto> GetGuests();
        Task<GuestDto?> GetGuestById(int id);
        Task<GuestDto> CreateGuest(GuestForCreateDto guestForCreateDto);
        Task UpdateGuest(GuestForCreateDto guestForCreateDto);
        Task DeleteGuest(int id);
    }
}
