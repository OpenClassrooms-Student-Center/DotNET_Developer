using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ReservationAPI.Controllers
{
	public interface IReservationsService
	{
		IEnumerable<ReservationDetail> All();

		ReservationDetail GetById(int id);

		void Delete(int id);

		ValidationResult Add(ReservationDetail item);
		IEnumerable<ReservationDetail> GetAvailableItems(DateTime day);
		IEnumerable<ReservationDetail> Get(DateTime day, int assetNumber);
	}
}