﻿using DTOsB.OrderBDTOs.OrderItemDTO;
using DTOsB.OrderDTO;
using DTOsB.Shared;

namespace ApplicationB.Services_B.Order
{
    public interface IOrderItemService
    {
        Task<ResultView<AddOrUpdateOrderItemBDTO>> CreateOrderItemAsync(AddOrUpdateOrderItemBDTO orderItemBDTO);
        Task<ResultView<AddOrUpdateOrderItemBDTO>> UpdateOrderItemAsync(AddOrUpdateOrderItemBDTO orderItemBDTO);
        Task<ResultView<SelectOrderItemBDTO>> DeleteOrderItemAsync(int id);
        Task<ResultView<SelectOrderItemBDTO>> GetOrderItemByIdAsync(int id);
        public IQueryable<SelectOrderItemBDTO> GetAllOrderItemsAsync();
    }
}