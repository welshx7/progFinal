using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progFinal
{
    internal class invSlot
    {
        private int slotNum;
        private Button invSlotObj;
        private item item;

        public invSlot(int slotNum, Button invSlotObj) {
            this.slotNum = slotNum;
            this.invSlotObj = invSlotObj;
            this.item = null;
        }

        public void setItem(item item) {
            this.item = item;

            if (item != null ) {
                invSlotObj.Text = item.getItemName();
            } else {
                invSlotObj.Text = "";
            }
            
        }

        public item getItem() { 
            return this.item; 
        }

        public void setText(string text) {
            invSlotObj.Text=text;
        }

        public void setColor(int r, int g, int b) {
            invSlotObj.BackColor = Color.FromArgb(r, g, b);
        }

        public string getSaveData() {
            string dataString = null;


            if (item != null) { 
                dataString = "&item" + item.getQualityValue() + "-" + item.getOreType() + "-" + item.getItemValue() + "-" + slotNum;
            }

            return dataString;
        }
    }
}
