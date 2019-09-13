using System;
using EmpilhadeiraAutoguiada.Webapi.Domain;

namespace EmpilhadeiraAutoguiada.Webapi.ViewModels
{
    public class SessionViewModel
    {
        public Guid Id { get; set; }

        public static implicit operator SessionViewModel(Session session)
        {
            if (session == null)
                return null;

            return new SessionViewModel
            {
                Id = session.Id
            };
        }
    }
}