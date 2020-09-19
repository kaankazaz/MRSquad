using System;
using System.Collections.Generic;
using System.Text;

namespace MRSquad.Library
{
    [Serializable()]
    public class MRSquadException : System.Exception
    {
        public MRSquadException() : base() { }
        public MRSquadException(string message) : base(message) { }
        public MRSquadException(string message, System.Exception inner) : base(message, inner) { }

        protected MRSquadException(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

    }
}
