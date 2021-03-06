﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace HiddenObjectStudio.Core.InventoriesManagement
{
    public class Inventories
    {
        public List<InventoryItem> IntentoryItems;

        private XmlDocument _inventoriesDocument;
        
        public String _filePath = String.Empty;

        public Inventories(string filePath)
        {
            _filePath = filePath;
            if (File.Exists(_filePath))
            {
                _inventoriesDocument = new XmlDocument();
                Tools.TryToLoad(_inventoriesDocument, _filePath);
                //_inventoriesDocument.Load(_filePath);

                IntentoryItems = new List<InventoryItem>();

                LoadFromXML(_inventoriesDocument.DocumentElement);

            }
        }
    

        public void LoadInventoriesXMl(string filePath)
        {
            _filePath = filePath;
            if (File.Exists(_filePath))
            {
                _inventoriesDocument = new XmlDocument();
                Tools.TryToLoad(_inventoriesDocument, _filePath);
                //_inventoriesDocument.Load(_filePath);

                IntentoryItems = new List<InventoryItem>();

                LoadFromXML(_inventoriesDocument.DocumentElement);
                
            }
        }

        private void LoadFromXML(XmlNode parentNode)
        {
            foreach (XmlNode nodes in parentNode)
            {
                if (nodes.NodeType != XmlNodeType.Comment)
                {
                    InventoryItem newIntentoryItem = new InventoryItem(nodes);
                    IntentoryItems.Add(newIntentoryItem);
                }
                
            }
        }

        public InventoryItem GetInventoryItemByName(string invItemName)
        {
            InventoryItem foundIntentoryItem;
            foreach (InventoryItem invItem in IntentoryItems)
            {
                if (invItem.Name == invItemName)
                {
                    foundIntentoryItem = invItem;
                    return foundIntentoryItem;
                }
            }
            return null;
        }

    }
}
