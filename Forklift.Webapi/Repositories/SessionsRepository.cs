using System;
using System.Collections.Generic;
using System.Linq;
using Forklift.Webapi.Domain;

namespace EmpilhadeiraAutoguiada.Webapi.Repositories
{
    public class SessionsRepository
    {
        private IList<Session> _sessions;

        public SessionsRepository()
        {
            _sessions = new List<Session>();
        }

        public void AddSession(Session session)
        {
            if (_sessions.Any(s => s.Id == session.Id))
                throw new ArgumentException();

            _sessions.Add(session);
        }

        public void DeleteSession(Guid id)
        {
            var session = _sessions.FirstOrDefault(s => s.Id == id);

            if (session != null)
                _sessions.Remove(session);
        }

        public Session GetSession(Guid id)
        {
            return _sessions.FirstOrDefault(s => s.Id == id);
        }
    }
}