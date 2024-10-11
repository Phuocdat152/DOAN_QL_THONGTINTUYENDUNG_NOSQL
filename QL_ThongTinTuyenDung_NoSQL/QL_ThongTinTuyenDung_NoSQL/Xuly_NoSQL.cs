using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace QL_ThongTinTuyenDung_NoSQL
{
    public class Xuly_NoSQL
    {
        private MongoClient client;
        private IMongoDatabase database;

        public string TaiKhoanQly { get; set; }
        public string PhanQuyen { get; set; }

        public Xuly_NoSQL(string databasename)
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase(databasename);
        }

        public Xuly_NoSQL()
        {
            client = new MongoClient("mongodb://localhost:27017");
            database = client.GetDatabase("QL_Tuyendung");
        }

        public Xuly_NoSQL kiemTraDN(string username, string password)
        {
            var collection = database.GetCollection<BsonDocument>("login");
            var filter = Builders<BsonDocument>.Filter.Eq("TaiKhoanQly", username) &
                          Builders<BsonDocument>.Filter.Eq("MatKhauQly", password);
            var document = collection.Find(filter).FirstOrDefault();

            if (document != null)
            {
                TaiKhoanQly = document["TaiKhoanQly"].AsString;
                PhanQuyen = document["PhanQuyen"].AsString;
                return this;
            }

            return null;
        }

        public DataTable LoadData(string collectionName)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var documents = collection.Find(new BsonDocument()).ToList();

            DataTable dataTable = new DataTable();
            List<string> excludedProperties = new List<string> { "NhiemVu", "ListCV" };

            foreach (var data in documents)
            {
                if (dataTable.Columns.Count == 0)
                {
                    CreateColumnsFromDocument(dataTable, data, "", excludedProperties);
                }

                var rowData = new List<object>();
                ExtractDataFromDocument(rowData, data, excludedProperties);
                dataTable.Rows.Add(rowData.ToArray());
            }

            return dataTable;
        }

        private void CreateColumnsFromDocument(DataTable dataTable, BsonDocument document, string prefix, List<string> excludedProperties)
        {
            foreach (var element in document.Elements)
            {
                if (!excludedProperties.Contains(element.Name))
                {
                    if (element.Value.IsBsonDocument)
                    {
                        CreateColumnsFromDocument(dataTable, element.Value.AsBsonDocument, prefix + element.Name + "_", excludedProperties);
                    }
                    else if (element.Value.IsBsonArray)
                    {
                        var array = element.Value.AsBsonArray;
                        for (int i = 0; i < array.Count; i++)
                        {
                            if (array[i].IsBsonDocument)
                            {
                                CreateColumnsFromDocument(dataTable, array[i].AsBsonDocument, prefix + element.Name + i + "_", excludedProperties);
                            }
                            else
                            {
                                dataTable.Columns.Add(prefix + element.Name + i, typeof(object));
                            }
                        }
                    }
                    else
                    {
                        if (!dataTable.Columns.Contains(prefix + element.Name))
                        {
                            dataTable.Columns.Add(prefix + element.Name, typeof(object));
                        }
                    }
                }
            }
        }

        private void ExtractDataFromDocument(List<object> rowData, BsonDocument document, List<string> excludedProperties)
        {
            foreach (var element in document.Elements)
            {
                if (!excludedProperties.Contains(element.Name))
                {
                    if (element.Value.IsBsonDocument)
                    {
                        ExtractDataFromDocument(rowData, element.Value.AsBsonDocument, excludedProperties);
                    }
                    else if (element.Value.IsBsonArray)
                    {
                        var array = element.Value.AsBsonArray;
                        foreach (var arrayElement in array)
                        {
                            if (arrayElement.IsBsonDocument)
                            {
                                ExtractDataFromDocument(rowData, arrayElement.AsBsonDocument, excludedProperties);
                            }
                            else
                            {
                                rowData.Add(arrayElement);
                            }
                        }
                    }
                    else
                    {
                        rowData.Add(element.Value);
                    }
                }
            }
        }

        public void ThemDocumentVaoCollection(string collectionName, BsonDocument document)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            collection.InsertOne(document);
        }

        public void SuaDocumentTrongCollection(string collectionName, string documentId, BsonDocument newDocument)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));
            newDocument.Remove("_id");
            var result = collection.ReplaceOne(filter, newDocument);

            if (result.ModifiedCount > 0)
            {
                MessageBox.Show("Document đã được sửa.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Document phù hợp để sửa.");
            }
        }

        public void XoaDocumentTrongCollection(string collectionName, string documentId)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(documentId));
            var result = collection.DeleteOne(filter);

            if (result.DeletedCount > 0)
            {
                MessageBox.Show("Document đã được xóa.");
            }
            else
            {
                MessageBox.Show("Không tìm thấy Document phù hợp để xóa.");
            }
        }

        public DataTable TimKiemProperty(string collectionName, string propertyName, string propertyValue)
        {
            var collection = database.GetCollection<BsonDocument>(collectionName);
            var filter = Builders<BsonDocument>.Filter.Regex(propertyName, new BsonRegularExpression($"/{propertyValue}/i"));
            var documents = collection.Find(filter).ToList();

            DataTable dataTable = new DataTable();
            List<string> excludedProperties = new List<string> { "NhiemVu", "ListCV" };

            foreach (var data in documents)
            {
                if (dataTable.Columns.Count == 0)
                {
                    CreateColumnsFromDocument(dataTable, data, "", excludedProperties);
                }

                var rowData = new List<object>();
                ExtractDataFromDocument(rowData, data, excludedProperties);
                dataTable.Rows.Add(rowData.ToArray());
            }

            return dataTable;
        }
    }
}
