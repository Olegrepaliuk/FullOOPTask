using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab1Classes
{
    
   
    public partial class FormClasses : Form
    {
        static bool skip;
        public FormClasses()
        {
            InitializeComponent();
            Application.Idle += Application_Idle;

            //Document.Documents.Add(new Document("Doc1", 1, true));
            //Document.Documents.Add(new Document("Doc2", 2, true));
            //Document.Documents.Add(new Document("Doc3", 3, true));
            //Document.Documents.Add(new Document("Doc4", 4, true));


            //if (File.Exists("DBEmulation.xml"))
            //{
            //    Document.Elements = DBEmulation.Load().Documents;
            //    Part.Elements = DBEmulation.Load().Parts;
            //    Item.Elements = DBEmulation.Load().Items;
            //    Paragraph.Elements = DBEmulation.Load().Paragraphs;

            //    ItemInPart.ItemInParts = DBEmulation.Load().ItemInParts;
            //    PartInDocument.PartInDocuments = DBEmulation.Load().PartInDocuments;
            //    ParagraphInItem.ParagraphInItems = DBEmulation.Load().ParagraphInItems;

            //}

            //Document.Elements.LoadObj(StorageFormat.sfXml);


            Document.Elements = Base.LoadObj(Document.Elements);
            Part.Elements = Base.LoadObj(Part.Elements);
            Item.Elements = Base.LoadObj(Item.Elements);
            Paragraph.Elements = Base.LoadObj(Paragraph.Elements);
            ItemInPart.ItemInParts = Base.LoadObj(ItemInPart.ItemInParts);
            PartInDocument.PartInDocuments = Base.LoadObj(PartInDocument.PartInDocuments);
            ParagraphInItem.ParagraphInItems = Base.LoadObj(ParagraphInItem.ParagraphInItems);





            LoadDocs();
            rbCustom.Checked = true;
          
            File.WriteAllText("D:\\WorkControl.txt", "");
        }

        public List<Document> docs = new List<Document>();

        public void LoadDocs()
        {
            LBDocs.DataSource = null;
            LBDocs.DataSource = Document.Elements.Values.ToList();
        }


        public void LoadParts(bool LoadAll = false)
        {
            Object Obj = LBParts.SelectedItem;
            LBParts.DataSource = null;

            if (LoadAll)
            {
                LBParts.DataSource = Part.Elements.Values.ToList();
            }
            else
                if (LBDocs.SelectedIndex > -1)
                {
                    LBParts.DataSource = ((Document)LBDocs.SelectedItem).Parts;
                }        

             if (Obj != null)
             {
                  LBParts.SelectedItem = Obj;
             }            
        }
           
        
        public void LoadItems(bool LoadAll = false)
        {

 

            Object Obj = LBItems.SelectedItem;
            LBItems.DataSource = null;

            if (LoadAll)
            {
                LBItems.DataSource = Item.Elements.Values.ToList();
            }
            else
                if (LBParts.SelectedIndex > -1)
            {
                LBItems.DataSource = ((Part)LBParts.SelectedItem).Items;
            }

            if (Obj != null)
            {
                LBItems.SelectedItem = Obj;
            }



        }
        public void LoadParagraphs(bool LoadAll = false)
        {

            Object Obj = LBParagraphs.SelectedItem;
            LBParagraphs.DataSource = null;

            if(LoadAll)
            {
                LBParagraphs.DataSource = Paragraph.Elements.Values.ToList();
            }
            else

                if (LBItems.SelectedIndex > -1)
            {
                LBParagraphs.DataSource = ((Item)LBItems.SelectedItem).Paragraphs;
            }

            if (Obj != null)
            {
                LBParagraphs.SelectedItem = Obj;
            }


        }

        public void DeleteDocument(Document Doc)
        {
            if (Doc != null)
            {
                for (var i = (PartInDocument.PartInDocuments.Count-1); i >= 0; i--)
                    if (PartInDocument.PartInDocuments[i].Document == Doc)
                    {
                        PartInDocument.PartInDocuments.Remove(PartInDocument.PartInDocuments[i]);
                    }

                Document.Elements.Remove(Doc.Id);
            }

            LoadDocs();
        }

        public void DeletePart(Part P)
        {
            if (P != null)
            {
                for (var i = (PartInDocument.PartInDocuments.Count - 1); i >= 0; i--)
                    if (PartInDocument.PartInDocuments[i].Part == P)
                    {
                        PartInDocument.PartInDocuments.Remove(PartInDocument.PartInDocuments[i]);
                    }
                for (var i = (ItemInPart.ItemInParts.Count - 1); i >= 0; i--)
                    if (ItemInPart.ItemInParts[i].Part == P)
                    {
                        ItemInPart.ItemInParts.Remove(ItemInPart.ItemInParts[i]);
                    }
                Part.Elements.Remove(P.Id);
            }
            
            LoadParts();
        }

        public void DeleteItem(Item itm)
        {


            if (itm != null)
            {
                for (var i = (ItemInPart.ItemInParts.Count - 1); i >= 0; i--)
                    if (ItemInPart.ItemInParts[i].Item == itm)
                    {
                        ItemInPart.ItemInParts.Remove(ItemInPart.ItemInParts[i]);
                    }
                for (var i = (ParagraphInItem.ParagraphInItems.Count - 1); i >= 0; i--)
                    if (ParagraphInItem.ParagraphInItems[i].Item == itm)
                    {
                        ParagraphInItem.ParagraphInItems.Remove(ParagraphInItem.ParagraphInItems[i]);
                    }
                Item.Elements.Remove(itm.Id);
            }

            LoadItems();
            if (LBItems.Items.Count == 0) LBParagraphs.DataSource = null;
            

        }
        public void DeleteParagraph(Paragraph par)
        {

            //var par = ((Paragraph)LBParagraphs.SelectedItem);

            //((Item)LBItems.SelectedItem).Paragraphs.Remove(par);

            if(par != null)
            {
                for (var i = (ParagraphInItem.ParagraphInItems.Count - 1); i >= 0; i--)
                    if (ParagraphInItem.ParagraphInItems[i].Paragraph == par)
                    {
                        ParagraphInItem.ParagraphInItems.Remove(ParagraphInItem.ParagraphInItems[i]);
                    }
                Paragraph.Elements.Remove(par.Id);
            }

            LoadParagraphs();
        }

        
        public void AddDocument()
        {
            var localDoc = new Document(tbDocName.Text, Convert.ToInt32(tbDocNum.Text), chbDocIsEdt.Checked);
            //Document.Elements.Add(localDoc.Id, localDoc);
            LoadDocs();
        }

        public void AddPart(Document MasterDoc)
        {
            var p = new Part(Convert.ToInt32(tbPartNum.Text), tbPartName.Text);
            //Part.Elements.Add(p.Id, p);
            PartInDocument.PartInDocuments.Add(new PartInDocument(MasterDoc.Id, p.Id));
            LoadParts();          
        }

        public void AddItem(Part MasterPart)
        {
            var i = new Item(Convert.ToInt32(tbItmNum.Text), Convert.ToInt32(tbItmFontSize.Text));
            //Item.Elements.Add(i.Id, i);
            ItemInPart.ItemInParts.Add(new ItemInPart(MasterPart.Id, i.Id));
            LoadItems();

            //var refDc = docs.ElementAt(LBDocs.SelectedIndex).Parts;
            //var itm = refDc.ElementAt(LBParts.SelectedIndex).Items;
            //itm.Add(Item.CreateItem(Convert.ToInt32(tbItmNum.Text)));

            //items.Add(Item.CreateItem(Convert.ToInt32(tbItmNum.Text)));

        }

        public void AddParagraph(Item MasterItem)
        {
            //var refDc = docs.ElementAt(LBDocs.SelectedIndex).Parts;
            //var refItm = refDc.ElementAt(LBParts.SelectedIndex).Items;
            //var par = refItm.ElementAt(LBItems.SelectedIndex).Paragraphs;
            //par.Add(Paragraph.CreateParagraph(tbParText.Text));

            //paragraphs.Add(Paragraph.CreateParagraph(tbParText.Text));

            var p = new Paragraph(tbParText.Text, Convert.ToInt32(tbParSize.Text), chbParBold.Checked, Convert.ToInt32(tbParNum.Text));
            //((Item)LBItems.SelectedItem).Paragraphs.Add(p);
            ParagraphInItem.ParagraphInItems.Add(new ParagraphInItem(MasterItem.Id, p.Id));
            LoadParagraphs();
        }

        public void LinkDocPart(Document doc, Part part)
        {
            PartInDocument.PartInDocuments.Add(new PartInDocument(doc.Id, part.Id));
        }

        public void UnlinkDocPart(Document doc, Part part, ref bool notFound)
        {
            foreach(var item in PartInDocument.PartInDocuments)
            {
                if((item.Document == doc)&(item.Part == part))
                {
                    PartInDocument.PartInDocuments.Remove(item);
                    return;
                }
            }
            notFound = true;
        }

        public void LinkPrtItm(Part part, Item item)
        {
            ItemInPart.ItemInParts.Add(new ItemInPart(part.Id, item.Id));
        }

        public void UnlinkPrtItm(Part part, Item item, ref bool notFound)
        {
            foreach (var i in ItemInPart.ItemInParts)
            {
                if ((i.Part == part) & (i.Item == item))
                {
                    ItemInPart.ItemInParts.Remove(i);
                    return;
                }
            }
            notFound = true;
        }

        public void LinkItmPar(Item item, Paragraph par)
        {
            ParagraphInItem.ParagraphInItems.Add(new ParagraphInItem(item.Id, par.Id));
        }

        public void UnlinkItmPar(Item item, Paragraph par, ref bool notFound)
        {
            foreach (var pii in ParagraphInItem.ParagraphInItems)
            {
                if ((pii.Item == item) & (pii.Paragraph == par))
                {
                    ParagraphInItem.ParagraphInItems.Remove(pii);
                    return;
                }
            }
            notFound = true;
        }


        private void btCreateDoc_Click(object sender, EventArgs e)
        {
            
            if (rbDefault.Checked)
            {
                int objAmt = (int)nudAmount.Value;
                
                
                if(objAmt == 1)
                {
                    var localDoc = new Document();
                    //Document.Elements.Add(localDoc.Id, localDoc);
                    LoadDocs();
                    return;
                }
                if(objAmt > 1)
                {
                   
                    new Document(objAmt);
                    LoadDocs();
                    return;
                }

            }

            bool uniName = true;
            foreach (Document doc in Document.Elements.Values)
            {
                
                if (String.Compare(doc.Name, tbDocName.Text, StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    uniName = false;
                    break;
                }
            }
            if (!uniName)
            {
                MessageBox.Show("Document with this name has been already created");
            }
            else
            {
                AddDocument();
            }
            
            
        }

        

        private void btCreatePart_Click(object sender, EventArgs e)
        {
            
            bool uniName = true;
            foreach(Part prt in (Part.Elements.Values))
            {
                if(String.Compare(prt.Name, tbPartName.Text, StringComparison.CurrentCultureIgnoreCase)== 0)
                {
                    uniName = false;
                    break;
                }
            }
            if(!uniName)
            {
                MessageBox.Show("Part with this name has been already created. You can link it to chosen document");
            }
            else
            {
                AddPart(((Document)LBDocs.SelectedItem));
            }
            
        }

        private void btCreateItm_Click(object sender, EventArgs e)
        {
            bool uniName = true;
            foreach (var itm in Item.Elements.Values)
            {
                if (itm.Number == Convert.ToInt32(tbItmNum.Text))
                {
                    uniName = false;
                    break;
                }
            }
            if (!uniName)
            {
                MessageBox.Show("Item with this number has been already created. You can link it to chosen part");
            }
            else
            {
                AddItem((Part)LBParts.SelectedItem);
                //AddItem(((Part)LBParts.SelectedItem));
            }

        }

        private void btCreatePar_Click(object sender, EventArgs e)
        {
            AddParagraph((Item)LBItems.SelectedItem);
        }

        private void btDeleteDoc_Click(object sender, EventArgs e)
        {
            DeleteDocument((Document)LBDocs.SelectedItem);
        }

        private void btDeletePart_Click(object sender, EventArgs e)
        {
            DeletePart((Part)LBParts.SelectedItem);
        }

        private void btDeleteItm_Click(object sender, EventArgs e)
        {
            DeleteItem((Item)LBItems.SelectedItem);
        }

        private void btDeletePar_Click(object sender, EventArgs e)
        {
            DeleteParagraph((Paragraph)LBParagraphs.SelectedItem);
        }

        private void LBParts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbShowAll.Checked) return;
            if (skip) return;
            if ((LBDocs.SelectedIndex < 0)|(LBParts.SelectedIndex<0)) return;
            //tbDocName.Text = docs.ElementAt<Document>(LBDocs.SelectedIndex).Name;
            //tbDocID.Text = Convert.ToString(docs.ElementAt<Document>(LBDocs.SelectedIndex).Id);
            //tbPartName.Text = docs.ElementAt(LBDocs.SelectedIndex).Parts.ElementAt<Part>(LBParts.SelectedIndex).Name;
            //tbPartNum.Text = Convert.ToString(docs.ElementAt(LBDocs.SelectedIndex).Parts.ElementAt<Part>(LBParts.SelectedIndex).Number);

            tbPartName.Text = ((Part)(LBParts.SelectedItem)).Name;
            tbPartNum.Text = Convert.ToString(((Part)(LBParts.SelectedItem)).Number);

            LoadItems();
            LoadParagraphs();
            skip = false;
            //LoadItems();
        }

        private void LBItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            //maybe skip
            //if ((LBDocs.SelectedIndex < 0) | (LBParts.SelectedIndex < 0)|(LBItems.SelectedIndex<0)) return;
            //tbItmNum.Text = Convert.ToString(items.ElementAt(LBItems.SelectedIndex).Number);
            //CheckControls();

            //maybe skip
            if (chbShowAll.Checked) return;
            if ((LBParts.SelectedIndex < 0) | (LBItems.SelectedIndex < 0)) return;
            tbItmNum.Text = Convert.ToString(((Item)(LBItems.SelectedItem)).Number);
            LoadParagraphs();

        }

        private void LBParagraphs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBParagraphs.SelectedIndex < 0) return;
            //var refDc = docs.ElementAt(LBDocs.SelectedIndex).Parts;
            //var refItm = refDc.ElementAt(LBParts.SelectedIndex).Items;
            //var paragraphs = refItm.ElementAt(LBItems.SelectedIndex).Paragraphs;

            if (LBParagraphs.SelectedIndex < 0) return;
            tbParText.Text = ((Paragraph)LBParagraphs.SelectedItem).Text;
            tbParSize.Text = Convert.ToString(((Paragraph)LBParagraphs.SelectedItem).FontSize);
            chbParBold.Checked = ((Paragraph)LBParagraphs.SelectedItem).Bold;
            tbParNum.Text = Convert.ToString(((Paragraph)LBParagraphs.SelectedItem).Number);
            //CheckControls();
        }
        private void LBDocs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbShowAll.Checked) return;
            //if (LBDocs.SelectedIndex < 0) return;
            //tbDocName.Text = docs.ElementAt<Document>(LBDocs.SelectedIndex).Name;
            //tbDocID.Text = Convert.ToString(docs.ElementAt<Document>(LBDocs.SelectedIndex).Id);
            //chbDocIsEdt.Checked = docs.ElementAt<Document>(LBDocs.SelectedIndex).IsEditable;

            if (LBDocs.SelectedItem != null)
            {
               

                tbDocName.Text = ((Document)LBDocs.SelectedItem).Name;
                tbDocNum.Text = Convert.ToString(((Document)LBDocs.SelectedItem).Number);
                chbDocIsEdt.Checked = ((Document)LBDocs.SelectedItem).IsEditable;
                
                //LBParts.Items.Clear();
                //foreach (Part part in ((Document)LBDocs.SelectedItem).Parts)
                //    LBParts.Items.Add(part); //items
            }

            LoadParts();
            LoadItems();
            LoadParagraphs();

        }

        private void btDocEdit_Click(object sender, EventArgs e)
        {
            Document localDoc = (Document)LBDocs.SelectedItem;
            localDoc.EditGlobal(tbDocName.Text, Convert.ToInt32(tbDocNum.Text));
            //((Document)LBDocs.SelectedItem).Name = tbDocName.Text;
            //((Document)LBDocs.SelectedItem).Number = Convert.ToInt32(tbDocNum.Text);
            //((Document)LBDocs.SelectedItem).IsEditable = chbDocIsEdt.Checked;
            localDoc.IsEditable = chbDocIsEdt.Checked;
            LoadDocs();

        }

        private void btPartEdit_Click(object sender, EventArgs e)
        {

            //((Part)LBParts.SelectedItem).Name = tbPartName.Text;
            //((Part)LBParts.SelectedItem).Number = Convert.ToInt32(tbPartNum.Text);
            Part localPart = (Part)LBParts.SelectedItem;
            localPart.EditGlobal(tbPartName.Text, Convert.ToInt32(tbPartNum.Text));

            LoadParts();
        }

        private void btItmEdit_Click(object sender, EventArgs e)
        {
            Item localItem = (Item)LBItems.SelectedItem;
            localItem.EditTextDepend(Convert.ToInt32(tbItmFontSize.Text), chbItmBold.Checked);
            localItem.Number = Convert.ToInt32(tbItmNum.Text);
            LoadItems();
        }

        private void btParEdit_Click(object sender, EventArgs e)
        {
            var localParagraph = (Paragraph)LBParagraphs.SelectedItem;
            localParagraph.EditTextDepend(Convert.ToInt32(tbParSize.Text), chbParBold.Checked);
            localParagraph.Text = tbParText.Text;
            localParagraph.Number = Convert.ToInt32(tbParNum.Text);
            //((Paragraph)LBParagraphs.SelectedItem).Text = tbParText.Text;
            //((Paragraph)LBParagraphs.SelectedItem).FontSize = Convert.ToInt32(tbParSize.Text);
            //((Paragraph)LBParagraphs.SelectedItem).Bold = chbParBold.Checked;

            LoadParagraphs();
        }

        private void CheckControls()
        {
            bool chbEnabled = chbShowAll.Checked;
            
            bool dcEnabled = (LBDocs.SelectedIndex >= 0);
            bool prtEnabled = (LBParts.SelectedIndex >= 0);
            bool itmEnabled = (LBItems.SelectedIndex >= 0);
            bool parEnabled = (LBParagraphs.SelectedIndex >= 0);

            int res;
            
            bool dcRightNum = (Int32.TryParse(tbDocNum.Text, out res));
            bool prtRightNum = (Int32.TryParse(tbPartNum.Text, out res));
            bool itmRightNum = (Int32.TryParse(tbItmNum.Text, out res));
            bool itmRightNum2 = (Int32.TryParse(tbItmFontSize.Text, out res));
            bool parRightNum = (Int32.TryParse(tbParSize.Text, out res));

            bool dcIsPlus = false;
            bool prtIsPlus = false;
            bool itmIsPlus = false;
            bool itmIsPlus2 = false;
            bool parIsPlus = false;

            if (dcRightNum)
            {
                dcIsPlus = (Int32.Parse(tbDocNum.Text) > 0);
            }

            if (prtRightNum)
            {
                prtIsPlus = (Int32.Parse(tbPartNum.Text) > 0);
            }

            if (itmRightNum)
            {
                itmIsPlus = (Int32.Parse(tbItmNum.Text) > 0);
            }

            if (itmRightNum2)
            {
                itmIsPlus2 = (Int32.Parse(tbItmFontSize.Text) > 0);
            }

            if (parRightNum)
            {
                parIsPlus = (Int32.Parse(tbParSize.Text) > 0);
            }

            btDocEdit.Enabled = (dcEnabled)& (dcRightNum) &(tbDocName.Text != "") & (dcIsPlus) & (!chbEnabled);
            if(rbCustom.Checked)
            {
                btCreateDoc.Enabled = ((tbDocName.Text != "") & (dcRightNum) & (dcIsPlus) & (!chbEnabled));
            }
            else
            {
                btCreateDoc.Enabled = true;
            }
           
            btDeleteDoc.Enabled = (LBDocs.SelectedIndex >= 0)&(!chbEnabled);

            btCreatePart.Enabled = (tbPartName.Text!="")& (prtRightNum) & (dcEnabled) & (prtIsPlus) &(!chbEnabled);
            btDeletePart.Enabled = (prtEnabled) & (dcEnabled) & (!chbEnabled);
            btPartEdit.Enabled = (prtEnabled)&(dcEnabled)&(prtRightNum)&(prtIsPlus) & (!chbEnabled);

            btCreateItm.Enabled = (tbItmNum.Text != "")&(dcEnabled)&(prtEnabled)&(itmRightNum)&(itmIsPlus) & (!chbEnabled)&(itmIsPlus2);
            btDeleteItm.Enabled = (prtEnabled) & (dcEnabled) &(itmEnabled) & (!chbEnabled);
            btItmEdit.Enabled = (prtEnabled) & (dcEnabled)&(itmEnabled)&(itmRightNum) & (itmIsPlus) & (!chbEnabled) & (itmIsPlus2);

            btCreatePar.Enabled = (tbParText.Text != "")&(dcEnabled)&(prtEnabled)&(itmEnabled) & (!chbEnabled)&(parIsPlus);
            btDeletePar.Enabled = (prtEnabled) & (dcEnabled)&(itmEnabled)&(parEnabled) & (!chbEnabled);
            btParEdit.Enabled = (prtEnabled) & (dcEnabled)&(itmEnabled)&(parEnabled) & (!chbEnabled)&(parIsPlus);

            btLinkDocPrt.Enabled = chbShowAll.Checked;
            btUnlinkDocPrt.Enabled = chbShowAll.Checked;
            btLinkPrtItm.Enabled = chbShowAll.Checked;
            btUnlinkPrtItm.Enabled = chbShowAll.Checked;
            btLinkItmPar.Enabled = chbShowAll.Checked;
            btUnlinkItmPar.Enabled = chbShowAll.Checked;
        }
        private void Application_Idle(object sender, EventArgs e)
        {
            CheckControls();
        }


        private void chbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            LoadParts(chbShowAll.Checked);
            LoadItems(chbShowAll.Checked);
            LoadParagraphs(chbShowAll.Checked);
        }

        private void btLinkDocPrt_Click(object sender, EventArgs e)
        {
            if((LBDocs.SelectedItem != null)&(LBParts.SelectedItem != null))
            {
                var doc = (Document)(LBDocs.SelectedItem);
                var part = ((Part)(LBParts.SelectedItem));
                if (doc.Parts.Contains(part))
                {
                    MessageBox.Show("The document contains this part");
                }
                else
                {
                    LinkDocPart(doc, part);
                    MessageBox.Show("Part was successfully added to document");
                }
            }

            
        }

        private void btUnlinkDocPrt_Click(object sender, EventArgs e)
        {
            if ((LBDocs.SelectedItem != null) & (LBParts.SelectedItem != null))
            {
                bool notFound = false;
                var doc = (Document)LBDocs.SelectedItem;
                var part = (Part)LBParts.SelectedItem;
                UnlinkDocPart(doc, part, ref notFound);
                if(notFound)
                {
                    MessageBox.Show("The document doesn`t contain this part");
                }
                else
                {
                    MessageBox.Show("The part was successfully removed from document");
                }
            }
        }

        private void btLinkPrtItm_Click(object sender, EventArgs e)
        {
            if ((LBParts.SelectedItem != null) & (LBItems.SelectedItem != null))
            {
                
                var part = ((Part)(LBParts.SelectedItem));
                var item = (Item)(LBItems.SelectedItem);
                if (part.Items.Contains(item))
                {
                    MessageBox.Show("The part contains this item");
                }
                else
                {
                    LinkPrtItm(part, item);
                    MessageBox.Show("The item was successfully added to part");
                }
            }
        }

        private void btLinkItmPar_Click(object sender, EventArgs e)
        {
            if ((LBItems.SelectedItem != null) & (LBParagraphs.SelectedItem != null))
            {

                var paragraph = ((Paragraph)(LBParagraphs.SelectedItem));
                var item = (Item)(LBItems.SelectedItem);
                if (item.Paragraphs.Contains(paragraph))
                {
                    MessageBox.Show("The item contains this paragraph");
                }
                else
                {
                    LinkItmPar(item, paragraph);
                    MessageBox.Show("The paragraph was successfully added to item");
                }
            }
        }

        private void btUnlinkItmPar_Click(object sender, EventArgs e)
        {
            if ((LBItems.SelectedItem != null) & (LBParagraphs.SelectedItem != null))
            {
                bool notFound = false;
                var item = (Item)LBItems.SelectedItem;
                var paragraph = (Paragraph)LBParagraphs.SelectedItem;
                UnlinkItmPar(item, paragraph, ref notFound);
                if (notFound)
                {
                    MessageBox.Show("The item doesn`t contain this paragraph");
                }
                else
                {
                    MessageBox.Show("The paragraph was successfully removed from item");
                }
            }
        }

        private void btUnlinkPrtItm_Click(object sender, EventArgs e)
        {
            if ((LBParts.SelectedItem != null) & (LBItems.SelectedItem != null))
            {
                bool notFound = false;
                var part = (Part)LBDocs.SelectedItem;
                var item = (Item)LBParts.SelectedItem;
                UnlinkPrtItm(part, item, ref notFound);
                if (notFound)
                {
                    MessageBox.Show("The part doesn`t contain this item");
                }
                else
                {
                    MessageBox.Show("The item was successfully removed from part");
                }
            }
        }

        private void btStatDoc_Click(object sender, EventArgs e)
        {


            lbStatDoc.Text = "";
            lbStatDoc.Text += "Docs with two or more parts:";
            List<Document> res = Document.DocsWithTwoOrMoreParts(Document.Elements);
            foreach(var elem in res)
            {
                lbStatDoc.Text += " " + elem.Name;
            }
            lbStatDoc.Text += "\n";
            lbStatDoc.Text += "Docs with the longest name: ";
            List<Document> res2 = Document.TheLongestNameDocs(Document.Elements);
            foreach (var elem in res2)
            {
                lbStatDoc.Text += " " + elem.Name;
            }


            lbStatDoc.Text += "\n";
            lbStatDoc.Text += "Parts with two or more items:";
            List<Part> resPrt = Part.PartsWithTwoOrMoreItems(Part.Elements);
            foreach (var elem in resPrt)
            {
                lbStatDoc.Text += " " + elem.Name;
            }
            lbStatDoc.Text += "\n";
            lbStatDoc.Text += "Parts with the longest name: ";
            List<Part> resPrt2 = Part.TheLongestNameDocs(Part.Elements);
            foreach (var elem in resPrt2)
            {
                lbStatDoc.Text += " " + elem.Name;
            }
            lbStatDoc.Text += "\n";
            lbStatDoc.Text += "Items with two or more paragraphs: ";
            List<Item> resItm = Item.ItemsWithTwoOrMoreParagraphs(Item.Elements);
            foreach (var elem in resItm)
            {
                lbStatDoc.Text += " " + elem.Number;
            }

            lbStatDoc.Text += "\n";
            lbStatDoc.Text += "text length of all paragraphs: " + Convert.ToString(Paragraph.AllTextAmount(Paragraph.Elements));
            
        }

        private void FormClasses_Load(object sender, EventArgs e)
        {

        }

        private void FormClasses_FormClosing(object sender, FormClosingEventArgs e)
        {
            //new DBEmulation() { Documents = Document.Elements,
            //    Parts = Part.Elements,
            //    Items = Item.Elements,
            //    Paragraphs = Paragraph.Elements,
            //    ItemInParts = ItemInPart.ItemInParts,
            //    PartInDocuments = PartInDocument.PartInDocuments,
            //    ParagraphInItems = ParagraphInItem.ParagraphInItems}.Save();

            //DBEmulation.SaveObj(Document.Elements);
            //DBEmulation.SaveObj(Part.Elements);
            //DBEmulation.SaveObj(Item.Elements);
            //DBEmulation.SaveObj(Paragraph.Elements);


            //DBEmulation.SaveObj(ParagraphInItem.ParagraphInItems);

            //Document.Elements.SaveObj();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            lbInfo.Text = "Information was successfully saved. The latest info is in ";
            if (rbMemory.Checked)
            {
                Document.Elements.SaveObj(StorageFormat.sfMemory);
                Part.Elements.SaveObj(StorageFormat.sfMemory);
                Item.Elements.SaveObj(StorageFormat.sfMemory);
                Paragraph.Elements.SaveObj(StorageFormat.sfMemory);

                Base.SaveObj(PartInDocument.PartInDocuments);
                Base.SaveObj(ItemInPart.ItemInParts);
                Base.SaveObj(ParagraphInItem.ParagraphInItems);
                lbInfo.Text += "memory";
            }
            if(rbXml.Checked)
            {
                Document.Elements.SaveObj(StorageFormat.sfXml);
                Part.Elements.SaveObj(StorageFormat.sfXml);
                Item.Elements.SaveObj(StorageFormat.sfXml);
                Paragraph.Elements.SaveObj(StorageFormat.sfXml);

                Base.SaveObj(PartInDocument.PartInDocuments);
                Base.SaveObj(ItemInPart.ItemInParts);
                Base.SaveObj(ParagraphInItem.ParagraphInItems);
                lbInfo.Text += "XML file";
            }
            
            if(rbTxt.Checked)
            {
                Document.Elements.SaveObj(StorageFormat.sfText);
                Part.Elements.SaveObj(StorageFormat.sfText);
                Item.Elements.SaveObj(StorageFormat.sfText);
                Paragraph.Elements.SaveObj(StorageFormat.sfText);

                Base.SaveObj(PartInDocument.PartInDocuments);
                Base.SaveObj(ItemInPart.ItemInParts);
                Base.SaveObj(ParagraphInItem.ParagraphInItems);
                lbInfo.Text += "TXT file";
            }

        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (rbMemory.Checked)
            {
                Document.Elements.LoadObj(StorageFormat.sfMemory);
                Part.Elements.LoadObj(StorageFormat.sfMemory);
                Item.Elements.LoadObj(StorageFormat.sfMemory);
                Paragraph.Elements.LoadObj(StorageFormat.sfMemory);

                ItemInPart.ItemInParts = Base.LoadObj(ItemInPart.ItemInParts);
                PartInDocument.PartInDocuments = Base.LoadObj(PartInDocument.PartInDocuments);
                ParagraphInItem.ParagraphInItems = Base.LoadObj(ParagraphInItem.ParagraphInItems);
            }
            if (rbXml.Checked)
            {
                Document.Elements.LoadObj(StorageFormat.sfXml);
                Part.Elements.LoadObj(StorageFormat.sfXml);
                Item.Elements.LoadObj(StorageFormat.sfXml);
                Paragraph.Elements.LoadObj(StorageFormat.sfXml);

                ItemInPart.ItemInParts = Base.LoadObj(ItemInPart.ItemInParts);
                PartInDocument.PartInDocuments = Base.LoadObj(PartInDocument.PartInDocuments);
                ParagraphInItem.ParagraphInItems = Base.LoadObj(ParagraphInItem.ParagraphInItems);

            }
            if(rbTxt.Checked)
            {
                Document.Elements.LoadObj(StorageFormat.sfText);
                Part.Elements.LoadObj(StorageFormat.sfText);
                Item.Elements.LoadObj(StorageFormat.sfText);
                Paragraph.Elements.LoadObj(StorageFormat.sfText);

                ItemInPart.ItemInParts = Base.LoadObj(ItemInPart.ItemInParts);
                PartInDocument.PartInDocuments = Base.LoadObj(PartInDocument.PartInDocuments);
                ParagraphInItem.ParagraphInItems = Base.LoadObj(ParagraphInItem.ParagraphInItems);
            }
            LoadDocs();
        }
    }

 
}
