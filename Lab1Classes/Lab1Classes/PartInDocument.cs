using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab1Classes
{
    [DataContract]
    public class PartInDocument : Base
    {

        static public StorageList<PartInDocument> PartInDocuments = new StorageList<PartInDocument>();
        

        private Guid _documentId;
        private Guid _partId;

        [DataMember]
        public Part Part
        {
            get { return (Part)Part.Elements[_partId]; }
            set { _partId = value.Id; }
        }

        public PartInDocument (Guid docId, Guid partId)
        {
            _documentId = docId;
            _partId = partId;
        }

        [DataMember]
        public Document Document
        {
            get
            {
                foreach (Document document in Document.Elements.Values)
                    if (document.Id == _documentId)
                        return document;
                return null;
            }
            set { _documentId = value.Id; }
        }
  }
}
