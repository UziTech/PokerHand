using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace PokerHand
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class CheckPokerHand : System.Windows.Forms.Form
	{
		#region private stuff
		private System.Windows.Forms.GroupBox your1;
		private System.Windows.Forms.GroupBox table4;
		private System.Windows.Forms.GroupBox your2;
		private System.Windows.Forms.GroupBox table1;
		private System.Windows.Forms.GroupBox table2;
		private System.Windows.Forms.GroupBox table3;
		private System.Windows.Forms.GroupBox table5;
		private System.Windows.Forms.PictureBox h2;
		private System.Windows.Forms.PictureBox h3;
		private System.Windows.Forms.PictureBox h4;
		private System.Windows.Forms.PictureBox h5;
		private System.Windows.Forms.PictureBox h6;
		private System.Windows.Forms.PictureBox h7;
		private System.Windows.Forms.PictureBox h8;
		private System.Windows.Forms.PictureBox h9;
		private System.Windows.Forms.PictureBox h10;
		private System.Windows.Forms.PictureBox hj;
		private System.Windows.Forms.PictureBox hq;
		private System.Windows.Forms.PictureBox hk;
		private System.Windows.Forms.PictureBox ha;
		private System.Windows.Forms.PictureBox c2;
		private System.Windows.Forms.PictureBox c3;
		private System.Windows.Forms.PictureBox c4;
		private System.Windows.Forms.PictureBox c5;
		private System.Windows.Forms.PictureBox c6;
		private System.Windows.Forms.PictureBox c7;
		private System.Windows.Forms.PictureBox c8;
		private System.Windows.Forms.PictureBox c9;
		private System.Windows.Forms.PictureBox c10;
		private System.Windows.Forms.PictureBox cj;
		private System.Windows.Forms.PictureBox cq;
		private System.Windows.Forms.PictureBox ck;
		private System.Windows.Forms.PictureBox ca;
		private System.Windows.Forms.PictureBox d2;
		private System.Windows.Forms.PictureBox d3;
		private System.Windows.Forms.PictureBox d4;
		private System.Windows.Forms.PictureBox d5;
		private System.Windows.Forms.PictureBox d6;
		private System.Windows.Forms.PictureBox d7;
		private System.Windows.Forms.PictureBox d8;
		private System.Windows.Forms.PictureBox d9;
		private System.Windows.Forms.PictureBox d10;
		private System.Windows.Forms.PictureBox dj;
		private System.Windows.Forms.PictureBox dq;
		private System.Windows.Forms.PictureBox dk;
		private System.Windows.Forms.PictureBox da;
		private System.Windows.Forms.PictureBox s2;
		private System.Windows.Forms.PictureBox s3;
		private System.Windows.Forms.PictureBox s4;
		private System.Windows.Forms.PictureBox s5;
		private System.Windows.Forms.PictureBox s6;
		private System.Windows.Forms.PictureBox s7;
		private System.Windows.Forms.PictureBox s8;
		private System.Windows.Forms.PictureBox s9;
		private System.Windows.Forms.PictureBox s10;
		private System.Windows.Forms.PictureBox sj;
		private System.Windows.Forms.PictureBox sq;
		private System.Windows.Forms.PictureBox sk;
		private System.Windows.Forms.PictureBox sa;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Label hand;
		private System.Windows.Forms.Button random;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion
        public CheckPokerHand()
		{
			//
			// Required for Windows Form Designer support
			//
            InitializeComponent();
            InitializeCardArray();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}
        private void InitializeCardArray()
        {
            _cards[0] = h2;
            _cards[1] = h3;
            _cards[2] = h4;
            _cards[3] = h5;
            _cards[4] = h6;
            _cards[5] = h7;
            _cards[6] = h8;
            _cards[7] = h9;
            _cards[8] = h10;
            _cards[9] = hj;
            _cards[10] = hq;
            _cards[11] = hk;
            _cards[12] = ha;
            _cards[13] = c2;
            _cards[14] = c3;
            _cards[15] = c4;
            _cards[16] = c5;
            _cards[17] = c6;
            _cards[18] = c7;
            _cards[19] = c8;
            _cards[20] = c9;
            _cards[21] = c10;
            _cards[22] = cj;
            _cards[23] = cq;
            _cards[24] = ck;
            _cards[25] = ca;
            _cards[26] = d2;
            _cards[27] = d3;
            _cards[28] = d4;
            _cards[29] = d5;
            _cards[30] = d6;
            _cards[31] = d7;
            _cards[32] = d8;
            _cards[33] = d9;
            _cards[34] = d10;
            _cards[35] = dj;
            _cards[36] = dq;
            _cards[37] = dk;
            _cards[38] = da;
            _cards[39] = s2;
            _cards[40] = s3;
            _cards[41] = s4;
            _cards[42] = s5;
            _cards[43] = s6;
            _cards[44] = s7;
            _cards[45] = s8;
            _cards[46] = s9;
            _cards[47] = s10;
            _cards[48] = sj;
            _cards[49] = sq;
            _cards[50] = sk;
            _cards[51] = sa;
            int k = 0;
            for (int i = 1; i < 5; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    _cardNum[k++] = i * 100 + j;
                }
            }
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}
        /// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckPokerHand));
            this.h2 = new System.Windows.Forms.PictureBox();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.h4 = new System.Windows.Forms.PictureBox();
            this.h5 = new System.Windows.Forms.PictureBox();
            this.h6 = new System.Windows.Forms.PictureBox();
            this.h7 = new System.Windows.Forms.PictureBox();
            this.h8 = new System.Windows.Forms.PictureBox();
            this.h9 = new System.Windows.Forms.PictureBox();
            this.h10 = new System.Windows.Forms.PictureBox();
            this.hj = new System.Windows.Forms.PictureBox();
            this.hq = new System.Windows.Forms.PictureBox();
            this.hk = new System.Windows.Forms.PictureBox();
            this.ha = new System.Windows.Forms.PictureBox();
            this.c2 = new System.Windows.Forms.PictureBox();
            this.c3 = new System.Windows.Forms.PictureBox();
            this.c4 = new System.Windows.Forms.PictureBox();
            this.c5 = new System.Windows.Forms.PictureBox();
            this.c6 = new System.Windows.Forms.PictureBox();
            this.c7 = new System.Windows.Forms.PictureBox();
            this.c8 = new System.Windows.Forms.PictureBox();
            this.c9 = new System.Windows.Forms.PictureBox();
            this.c10 = new System.Windows.Forms.PictureBox();
            this.cj = new System.Windows.Forms.PictureBox();
            this.cq = new System.Windows.Forms.PictureBox();
            this.ck = new System.Windows.Forms.PictureBox();
            this.ca = new System.Windows.Forms.PictureBox();
            this.d2 = new System.Windows.Forms.PictureBox();
            this.d3 = new System.Windows.Forms.PictureBox();
            this.d4 = new System.Windows.Forms.PictureBox();
            this.d5 = new System.Windows.Forms.PictureBox();
            this.d6 = new System.Windows.Forms.PictureBox();
            this.d7 = new System.Windows.Forms.PictureBox();
            this.d8 = new System.Windows.Forms.PictureBox();
            this.d9 = new System.Windows.Forms.PictureBox();
            this.d10 = new System.Windows.Forms.PictureBox();
            this.dj = new System.Windows.Forms.PictureBox();
            this.dq = new System.Windows.Forms.PictureBox();
            this.dk = new System.Windows.Forms.PictureBox();
            this.da = new System.Windows.Forms.PictureBox();
            this.s2 = new System.Windows.Forms.PictureBox();
            this.s3 = new System.Windows.Forms.PictureBox();
            this.s4 = new System.Windows.Forms.PictureBox();
            this.s5 = new System.Windows.Forms.PictureBox();
            this.s6 = new System.Windows.Forms.PictureBox();
            this.s7 = new System.Windows.Forms.PictureBox();
            this.s8 = new System.Windows.Forms.PictureBox();
            this.s9 = new System.Windows.Forms.PictureBox();
            this.s10 = new System.Windows.Forms.PictureBox();
            this.sj = new System.Windows.Forms.PictureBox();
            this.sq = new System.Windows.Forms.PictureBox();
            this.sk = new System.Windows.Forms.PictureBox();
            this.your1 = new System.Windows.Forms.GroupBox();
            this.sa = new System.Windows.Forms.PictureBox();
            this.table4 = new System.Windows.Forms.GroupBox();
            this.your2 = new System.Windows.Forms.GroupBox();
            this.table1 = new System.Windows.Forms.GroupBox();
            this.table2 = new System.Windows.Forms.GroupBox();
            this.table3 = new System.Windows.Forms.GroupBox();
            this.table5 = new System.Windows.Forms.GroupBox();
            this.hand = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.random = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.da)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sa)).BeginInit();
            this.SuspendLayout();
            // 
            // h2
            // 
            this.h2.Image = ((System.Drawing.Image)(resources.GetObject("h2.Image")));
            this.h2.Location = new System.Drawing.Point(8, 8);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(90, 130);
            this.h2.TabIndex = 0;
            this.h2.TabStop = false;
            this.h2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h3
            // 
            this.h3.Image = ((System.Drawing.Image)(resources.GetObject("h3.Image")));
            this.h3.Location = new System.Drawing.Point(56, 8);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(90, 130);
            this.h3.TabIndex = 1;
            this.h3.TabStop = false;
            this.h3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h4
            // 
            this.h4.Image = ((System.Drawing.Image)(resources.GetObject("h4.Image")));
            this.h4.Location = new System.Drawing.Point(104, 8);
            this.h4.Name = "h4";
            this.h4.Size = new System.Drawing.Size(90, 130);
            this.h4.TabIndex = 2;
            this.h4.TabStop = false;
            this.h4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h5
            // 
            this.h5.Image = ((System.Drawing.Image)(resources.GetObject("h5.Image")));
            this.h5.Location = new System.Drawing.Point(152, 8);
            this.h5.Name = "h5";
            this.h5.Size = new System.Drawing.Size(90, 130);
            this.h5.TabIndex = 3;
            this.h5.TabStop = false;
            this.h5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h6
            // 
            this.h6.Image = ((System.Drawing.Image)(resources.GetObject("h6.Image")));
            this.h6.Location = new System.Drawing.Point(200, 8);
            this.h6.Name = "h6";
            this.h6.Size = new System.Drawing.Size(90, 130);
            this.h6.TabIndex = 4;
            this.h6.TabStop = false;
            this.h6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h7
            // 
            this.h7.Image = ((System.Drawing.Image)(resources.GetObject("h7.Image")));
            this.h7.Location = new System.Drawing.Point(248, 8);
            this.h7.Name = "h7";
            this.h7.Size = new System.Drawing.Size(90, 130);
            this.h7.TabIndex = 5;
            this.h7.TabStop = false;
            this.h7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h8
            // 
            this.h8.Image = ((System.Drawing.Image)(resources.GetObject("h8.Image")));
            this.h8.Location = new System.Drawing.Point(296, 8);
            this.h8.Name = "h8";
            this.h8.Size = new System.Drawing.Size(90, 130);
            this.h8.TabIndex = 6;
            this.h8.TabStop = false;
            this.h8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h9
            // 
            this.h9.Image = ((System.Drawing.Image)(resources.GetObject("h9.Image")));
            this.h9.Location = new System.Drawing.Point(344, 8);
            this.h9.Name = "h9";
            this.h9.Size = new System.Drawing.Size(90, 130);
            this.h9.TabIndex = 7;
            this.h9.TabStop = false;
            this.h9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // h10
            // 
            this.h10.Image = ((System.Drawing.Image)(resources.GetObject("h10.Image")));
            this.h10.Location = new System.Drawing.Point(392, 8);
            this.h10.Name = "h10";
            this.h10.Size = new System.Drawing.Size(90, 130);
            this.h10.TabIndex = 8;
            this.h10.TabStop = false;
            this.h10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // hj
            // 
            this.hj.Image = ((System.Drawing.Image)(resources.GetObject("hj.Image")));
            this.hj.Location = new System.Drawing.Point(440, 8);
            this.hj.Name = "hj";
            this.hj.Size = new System.Drawing.Size(90, 130);
            this.hj.TabIndex = 9;
            this.hj.TabStop = false;
            this.hj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // hq
            // 
            this.hq.Image = ((System.Drawing.Image)(resources.GetObject("hq.Image")));
            this.hq.Location = new System.Drawing.Point(488, 8);
            this.hq.Name = "hq";
            this.hq.Size = new System.Drawing.Size(90, 130);
            this.hq.TabIndex = 10;
            this.hq.TabStop = false;
            this.hq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // hk
            // 
            this.hk.Image = ((System.Drawing.Image)(resources.GetObject("hk.Image")));
            this.hk.Location = new System.Drawing.Point(536, 8);
            this.hk.Name = "hk";
            this.hk.Size = new System.Drawing.Size(90, 130);
            this.hk.TabIndex = 11;
            this.hk.TabStop = false;
            this.hk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // ha
            // 
            this.ha.Image = ((System.Drawing.Image)(resources.GetObject("ha.Image")));
            this.ha.Location = new System.Drawing.Point(584, 8);
            this.ha.Name = "ha";
            this.ha.Size = new System.Drawing.Size(90, 130);
            this.ha.TabIndex = 12;
            this.ha.TabStop = false;
            this.ha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c2
            // 
            this.c2.Image = ((System.Drawing.Image)(resources.GetObject("c2.Image")));
            this.c2.Location = new System.Drawing.Point(8, 88);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(90, 130);
            this.c2.TabIndex = 13;
            this.c2.TabStop = false;
            this.c2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c3
            // 
            this.c3.Image = ((System.Drawing.Image)(resources.GetObject("c3.Image")));
            this.c3.Location = new System.Drawing.Point(56, 88);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(90, 130);
            this.c3.TabIndex = 14;
            this.c3.TabStop = false;
            this.c3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c4
            // 
            this.c4.Image = ((System.Drawing.Image)(resources.GetObject("c4.Image")));
            this.c4.Location = new System.Drawing.Point(104, 88);
            this.c4.Name = "c4";
            this.c4.Size = new System.Drawing.Size(90, 130);
            this.c4.TabIndex = 15;
            this.c4.TabStop = false;
            this.c4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c5
            // 
            this.c5.Image = ((System.Drawing.Image)(resources.GetObject("c5.Image")));
            this.c5.Location = new System.Drawing.Point(152, 88);
            this.c5.Name = "c5";
            this.c5.Size = new System.Drawing.Size(90, 130);
            this.c5.TabIndex = 16;
            this.c5.TabStop = false;
            this.c5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c6
            // 
            this.c6.Image = ((System.Drawing.Image)(resources.GetObject("c6.Image")));
            this.c6.Location = new System.Drawing.Point(200, 88);
            this.c6.Name = "c6";
            this.c6.Size = new System.Drawing.Size(90, 130);
            this.c6.TabIndex = 17;
            this.c6.TabStop = false;
            this.c6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c7
            // 
            this.c7.Image = ((System.Drawing.Image)(resources.GetObject("c7.Image")));
            this.c7.Location = new System.Drawing.Point(248, 88);
            this.c7.Name = "c7";
            this.c7.Size = new System.Drawing.Size(90, 130);
            this.c7.TabIndex = 18;
            this.c7.TabStop = false;
            this.c7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c8
            // 
            this.c8.Image = ((System.Drawing.Image)(resources.GetObject("c8.Image")));
            this.c8.Location = new System.Drawing.Point(296, 88);
            this.c8.Name = "c8";
            this.c8.Size = new System.Drawing.Size(90, 130);
            this.c8.TabIndex = 19;
            this.c8.TabStop = false;
            this.c8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c9
            // 
            this.c9.Image = ((System.Drawing.Image)(resources.GetObject("c9.Image")));
            this.c9.Location = new System.Drawing.Point(344, 88);
            this.c9.Name = "c9";
            this.c9.Size = new System.Drawing.Size(90, 130);
            this.c9.TabIndex = 20;
            this.c9.TabStop = false;
            this.c9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // c10
            // 
            this.c10.Image = ((System.Drawing.Image)(resources.GetObject("c10.Image")));
            this.c10.Location = new System.Drawing.Point(392, 88);
            this.c10.Name = "c10";
            this.c10.Size = new System.Drawing.Size(90, 130);
            this.c10.TabIndex = 21;
            this.c10.TabStop = false;
            this.c10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // cj
            // 
            this.cj.Image = ((System.Drawing.Image)(resources.GetObject("cj.Image")));
            this.cj.Location = new System.Drawing.Point(440, 88);
            this.cj.Name = "cj";
            this.cj.Size = new System.Drawing.Size(90, 130);
            this.cj.TabIndex = 22;
            this.cj.TabStop = false;
            this.cj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // cq
            // 
            this.cq.Image = ((System.Drawing.Image)(resources.GetObject("cq.Image")));
            this.cq.Location = new System.Drawing.Point(488, 88);
            this.cq.Name = "cq";
            this.cq.Size = new System.Drawing.Size(90, 130);
            this.cq.TabIndex = 23;
            this.cq.TabStop = false;
            this.cq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // ck
            // 
            this.ck.Image = ((System.Drawing.Image)(resources.GetObject("ck.Image")));
            this.ck.Location = new System.Drawing.Point(536, 88);
            this.ck.Name = "ck";
            this.ck.Size = new System.Drawing.Size(90, 130);
            this.ck.TabIndex = 24;
            this.ck.TabStop = false;
            this.ck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // ca
            // 
            this.ca.Image = ((System.Drawing.Image)(resources.GetObject("ca.Image")));
            this.ca.Location = new System.Drawing.Point(584, 88);
            this.ca.Name = "ca";
            this.ca.Size = new System.Drawing.Size(90, 130);
            this.ca.TabIndex = 25;
            this.ca.TabStop = false;
            this.ca.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d2
            // 
            this.d2.Image = ((System.Drawing.Image)(resources.GetObject("d2.Image")));
            this.d2.Location = new System.Drawing.Point(8, 168);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(90, 130);
            this.d2.TabIndex = 26;
            this.d2.TabStop = false;
            this.d2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d3
            // 
            this.d3.Image = ((System.Drawing.Image)(resources.GetObject("d3.Image")));
            this.d3.Location = new System.Drawing.Point(56, 168);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(90, 130);
            this.d3.TabIndex = 27;
            this.d3.TabStop = false;
            this.d3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d4
            // 
            this.d4.Image = ((System.Drawing.Image)(resources.GetObject("d4.Image")));
            this.d4.Location = new System.Drawing.Point(104, 168);
            this.d4.Name = "d4";
            this.d4.Size = new System.Drawing.Size(90, 130);
            this.d4.TabIndex = 28;
            this.d4.TabStop = false;
            this.d4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d5
            // 
            this.d5.Image = ((System.Drawing.Image)(resources.GetObject("d5.Image")));
            this.d5.Location = new System.Drawing.Point(152, 168);
            this.d5.Name = "d5";
            this.d5.Size = new System.Drawing.Size(90, 130);
            this.d5.TabIndex = 29;
            this.d5.TabStop = false;
            this.d5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d6
            // 
            this.d6.Image = ((System.Drawing.Image)(resources.GetObject("d6.Image")));
            this.d6.Location = new System.Drawing.Point(200, 168);
            this.d6.Name = "d6";
            this.d6.Size = new System.Drawing.Size(90, 130);
            this.d6.TabIndex = 30;
            this.d6.TabStop = false;
            this.d6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d7
            // 
            this.d7.Image = ((System.Drawing.Image)(resources.GetObject("d7.Image")));
            this.d7.Location = new System.Drawing.Point(248, 168);
            this.d7.Name = "d7";
            this.d7.Size = new System.Drawing.Size(90, 130);
            this.d7.TabIndex = 31;
            this.d7.TabStop = false;
            this.d7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d8
            // 
            this.d8.Image = ((System.Drawing.Image)(resources.GetObject("d8.Image")));
            this.d8.Location = new System.Drawing.Point(296, 168);
            this.d8.Name = "d8";
            this.d8.Size = new System.Drawing.Size(90, 130);
            this.d8.TabIndex = 32;
            this.d8.TabStop = false;
            this.d8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d9
            // 
            this.d9.Image = ((System.Drawing.Image)(resources.GetObject("d9.Image")));
            this.d9.Location = new System.Drawing.Point(344, 168);
            this.d9.Name = "d9";
            this.d9.Size = new System.Drawing.Size(90, 130);
            this.d9.TabIndex = 33;
            this.d9.TabStop = false;
            this.d9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // d10
            // 
            this.d10.Image = ((System.Drawing.Image)(resources.GetObject("d10.Image")));
            this.d10.Location = new System.Drawing.Point(392, 168);
            this.d10.Name = "d10";
            this.d10.Size = new System.Drawing.Size(90, 130);
            this.d10.TabIndex = 34;
            this.d10.TabStop = false;
            this.d10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // dj
            // 
            this.dj.Image = ((System.Drawing.Image)(resources.GetObject("dj.Image")));
            this.dj.Location = new System.Drawing.Point(440, 168);
            this.dj.Name = "dj";
            this.dj.Size = new System.Drawing.Size(90, 130);
            this.dj.TabIndex = 35;
            this.dj.TabStop = false;
            this.dj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // dq
            // 
            this.dq.Image = ((System.Drawing.Image)(resources.GetObject("dq.Image")));
            this.dq.Location = new System.Drawing.Point(488, 168);
            this.dq.Name = "dq";
            this.dq.Size = new System.Drawing.Size(90, 130);
            this.dq.TabIndex = 36;
            this.dq.TabStop = false;
            this.dq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // dk
            // 
            this.dk.Image = ((System.Drawing.Image)(resources.GetObject("dk.Image")));
            this.dk.Location = new System.Drawing.Point(536, 168);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(90, 130);
            this.dk.TabIndex = 37;
            this.dk.TabStop = false;
            this.dk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // da
            // 
            this.da.Image = ((System.Drawing.Image)(resources.GetObject("da.Image")));
            this.da.Location = new System.Drawing.Point(584, 168);
            this.da.Name = "da";
            this.da.Size = new System.Drawing.Size(90, 130);
            this.da.TabIndex = 38;
            this.da.TabStop = false;
            this.da.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s2
            // 
            this.s2.Image = ((System.Drawing.Image)(resources.GetObject("s2.Image")));
            this.s2.Location = new System.Drawing.Point(8, 248);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(90, 130);
            this.s2.TabIndex = 39;
            this.s2.TabStop = false;
            this.s2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s3
            // 
            this.s3.Image = ((System.Drawing.Image)(resources.GetObject("s3.Image")));
            this.s3.Location = new System.Drawing.Point(56, 248);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(90, 130);
            this.s3.TabIndex = 40;
            this.s3.TabStop = false;
            this.s3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s4
            // 
            this.s4.Image = ((System.Drawing.Image)(resources.GetObject("s4.Image")));
            this.s4.Location = new System.Drawing.Point(104, 248);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(90, 130);
            this.s4.TabIndex = 41;
            this.s4.TabStop = false;
            this.s4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s5
            // 
            this.s5.Image = ((System.Drawing.Image)(resources.GetObject("s5.Image")));
            this.s5.Location = new System.Drawing.Point(152, 248);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(90, 130);
            this.s5.TabIndex = 42;
            this.s5.TabStop = false;
            this.s5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s6
            // 
            this.s6.Image = ((System.Drawing.Image)(resources.GetObject("s6.Image")));
            this.s6.Location = new System.Drawing.Point(200, 248);
            this.s6.Name = "s6";
            this.s6.Size = new System.Drawing.Size(90, 130);
            this.s6.TabIndex = 43;
            this.s6.TabStop = false;
            this.s6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s7
            // 
            this.s7.Image = ((System.Drawing.Image)(resources.GetObject("s7.Image")));
            this.s7.Location = new System.Drawing.Point(248, 248);
            this.s7.Name = "s7";
            this.s7.Size = new System.Drawing.Size(90, 130);
            this.s7.TabIndex = 44;
            this.s7.TabStop = false;
            this.s7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s8
            // 
            this.s8.Image = ((System.Drawing.Image)(resources.GetObject("s8.Image")));
            this.s8.Location = new System.Drawing.Point(296, 248);
            this.s8.Name = "s8";
            this.s8.Size = new System.Drawing.Size(90, 130);
            this.s8.TabIndex = 45;
            this.s8.TabStop = false;
            this.s8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s9
            // 
            this.s9.Image = ((System.Drawing.Image)(resources.GetObject("s9.Image")));
            this.s9.Location = new System.Drawing.Point(344, 248);
            this.s9.Name = "s9";
            this.s9.Size = new System.Drawing.Size(90, 130);
            this.s9.TabIndex = 46;
            this.s9.TabStop = false;
            this.s9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // s10
            // 
            this.s10.Image = ((System.Drawing.Image)(resources.GetObject("s10.Image")));
            this.s10.Location = new System.Drawing.Point(392, 248);
            this.s10.Name = "s10";
            this.s10.Size = new System.Drawing.Size(90, 130);
            this.s10.TabIndex = 47;
            this.s10.TabStop = false;
            this.s10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // sj
            // 
            this.sj.Image = ((System.Drawing.Image)(resources.GetObject("sj.Image")));
            this.sj.Location = new System.Drawing.Point(440, 248);
            this.sj.Name = "sj";
            this.sj.Size = new System.Drawing.Size(90, 130);
            this.sj.TabIndex = 48;
            this.sj.TabStop = false;
            this.sj.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // sq
            // 
            this.sq.Image = ((System.Drawing.Image)(resources.GetObject("sq.Image")));
            this.sq.Location = new System.Drawing.Point(488, 248);
            this.sq.Name = "sq";
            this.sq.Size = new System.Drawing.Size(90, 130);
            this.sq.TabIndex = 49;
            this.sq.TabStop = false;
            this.sq.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // sk
            // 
            this.sk.Image = ((System.Drawing.Image)(resources.GetObject("sk.Image")));
            this.sk.Location = new System.Drawing.Point(536, 248);
            this.sk.Name = "sk";
            this.sk.Size = new System.Drawing.Size(90, 130);
            this.sk.TabIndex = 50;
            this.sk.TabStop = false;
            this.sk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // your1
            // 
            this.your1.ForeColor = System.Drawing.Color.Yellow;
            this.your1.Location = new System.Drawing.Point(8, 384);
            this.your1.Name = "your1";
            this.your1.Size = new System.Drawing.Size(90, 152);
            this.your1.TabIndex = 52;
            this.your1.TabStop = false;
            this.your1.Text = "Your Card #1";
            // 
            // sa
            // 
            this.sa.Image = ((System.Drawing.Image)(resources.GetObject("sa.Image")));
            this.sa.Location = new System.Drawing.Point(584, 248);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(90, 130);
            this.sa.TabIndex = 53;
            this.sa.TabStop = false;
            this.sa.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardMouseDown);
            // 
            // table4
            // 
            this.table4.ForeColor = System.Drawing.Color.Yellow;
            this.table4.Location = new System.Drawing.Point(488, 384);
            this.table4.Name = "table4";
            this.table4.Size = new System.Drawing.Size(90, 152);
            this.table4.TabIndex = 53;
            this.table4.TabStop = false;
            this.table4.Text = "Turn";
            // 
            // your2
            // 
            this.your2.ForeColor = System.Drawing.Color.Yellow;
            this.your2.Location = new System.Drawing.Point(104, 384);
            this.your2.Name = "your2";
            this.your2.Size = new System.Drawing.Size(90, 152);
            this.your2.TabIndex = 53;
            this.your2.TabStop = false;
            this.your2.Text = "Your Card #2";
            // 
            // table1
            // 
            this.table1.ForeColor = System.Drawing.Color.Yellow;
            this.table1.Location = new System.Drawing.Point(200, 384);
            this.table1.Name = "table1";
            this.table1.Size = new System.Drawing.Size(90, 152);
            this.table1.TabIndex = 53;
            this.table1.TabStop = false;
            this.table1.Text = "Flop";
            // 
            // table2
            // 
            this.table2.ForeColor = System.Drawing.Color.Yellow;
            this.table2.Location = new System.Drawing.Point(296, 384);
            this.table2.Name = "table2";
            this.table2.Size = new System.Drawing.Size(90, 152);
            this.table2.TabIndex = 53;
            this.table2.TabStop = false;
            this.table2.Text = "Flop";
            // 
            // table3
            // 
            this.table3.ForeColor = System.Drawing.Color.Yellow;
            this.table3.Location = new System.Drawing.Point(392, 384);
            this.table3.Name = "table3";
            this.table3.Size = new System.Drawing.Size(90, 152);
            this.table3.TabIndex = 53;
            this.table3.TabStop = false;
            this.table3.Text = "Flop";
            // 
            // table5
            // 
            this.table5.ForeColor = System.Drawing.Color.Yellow;
            this.table5.Location = new System.Drawing.Point(584, 384);
            this.table5.Name = "table5";
            this.table5.Size = new System.Drawing.Size(90, 152);
            this.table5.TabIndex = 54;
            this.table5.TabStop = false;
            this.table5.Text = "River";
            // 
            // hand
            // 
            this.hand.ForeColor = System.Drawing.Color.Yellow;
            this.hand.Location = new System.Drawing.Point(0, 544);
            this.hand.Name = "hand";
            this.hand.Size = new System.Drawing.Size(544, 24);
            this.hand.TabIndex = 55;
            this.hand.Text = "Click on a card and drag it to a position. Once all of the positions are filled y" +
                "our poker hand will be revealed.";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.Red;
            this.reset.ForeColor = System.Drawing.Color.DarkGreen;
            this.reset.Location = new System.Drawing.Point(624, 544);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(48, 24);
            this.reset.TabIndex = 56;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // random
            // 
            this.random.BackColor = System.Drawing.Color.Red;
            this.random.ForeColor = System.Drawing.Color.DarkGreen;
            this.random.Location = new System.Drawing.Point(552, 544);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(56, 24);
            this.random.TabIndex = 57;
            this.random.Text = "Random";
            this.random.UseVisualStyleBackColor = false;
            this.random.Click += new System.EventHandler(this.random_Click);
            // 
            // CheckPokerHand
            // 
            this.AllowDrop = true;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(680, 574);
            this.Controls.Add(this.random);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.hand);
            this.Controls.Add(this.sa);
            this.Controls.Add(this.your1);
            this.Controls.Add(this.sk);
            this.Controls.Add(this.sq);
            this.Controls.Add(this.sj);
            this.Controls.Add(this.s10);
            this.Controls.Add(this.s9);
            this.Controls.Add(this.s8);
            this.Controls.Add(this.s7);
            this.Controls.Add(this.s6);
            this.Controls.Add(this.s5);
            this.Controls.Add(this.s4);
            this.Controls.Add(this.s3);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.da);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.dq);
            this.Controls.Add(this.dj);
            this.Controls.Add(this.d10);
            this.Controls.Add(this.d9);
            this.Controls.Add(this.d8);
            this.Controls.Add(this.d7);
            this.Controls.Add(this.d6);
            this.Controls.Add(this.d5);
            this.Controls.Add(this.d4);
            this.Controls.Add(this.d3);
            this.Controls.Add(this.d2);
            this.Controls.Add(this.ca);
            this.Controls.Add(this.ck);
            this.Controls.Add(this.cq);
            this.Controls.Add(this.cj);
            this.Controls.Add(this.c10);
            this.Controls.Add(this.c9);
            this.Controls.Add(this.c8);
            this.Controls.Add(this.c7);
            this.Controls.Add(this.c6);
            this.Controls.Add(this.c5);
            this.Controls.Add(this.c4);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.ha);
            this.Controls.Add(this.hk);
            this.Controls.Add(this.hq);
            this.Controls.Add(this.hj);
            this.Controls.Add(this.h10);
            this.Controls.Add(this.h9);
            this.Controls.Add(this.h8);
            this.Controls.Add(this.h7);
            this.Controls.Add(this.h6);
            this.Controls.Add(this.h5);
            this.Controls.Add(this.h4);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.table3);
            this.Controls.Add(this.table2);
            this.Controls.Add(this.table1);
            this.Controls.Add(this.your2);
            this.Controls.Add(this.table4);
            this.Controls.Add(this.table5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckPokerHand";
            this.Text = "Check Poker Hand created by Tony Brix   UziTech.com";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CheckPokerHand_DragDrop);
            this.DragOver += new System.Windows.Forms.DragEventHandler(this.CheckPokerHand_DragOver);
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.d10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.da)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sa)).EndInit();
            this.ResumeLayout(false);

		}
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new CheckPokerHand());
		}
		#region Global Variables
		int [] _unsorted = new int[14];
		int [] _hand = new int[14];
		PictureBox _mc = null;
        PictureBox[] _cards = new PictureBox[52];
        int[] _cardNum = new int[52];
		int _mx = 0;
		int _my = 0;
		int _cx = 0;
		int _cy = 0;
		#endregion
		private void CheckPokerHand_DragOver(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (_mc != null)
			{
                e.Effect = DragDropEffects.Move;
				Point p = this.PointToClient(new Point(e.X, e.Y));
				_mc.Left = p.X - _mx;
				_mc.Top = p.Y - _my;
				_mc.Visible=true;
			}
		}
		private void CheckPokerHand_DragDrop(object sender, System.EventArgs e)
		{
			if(_mc.Left >= 0 && _mc.Left <= 58 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[7] == 0)
			{
				_hand[7] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 8;
				_mc.Top = 408;
			}
			else if(_mc.Left >= 15 && _mc.Left <= 154 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[8] == 0)
			{
				_hand[8] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 104;
				_mc.Top = 408;
			}
			else if(_mc.Left >= 111 && _mc.Left <= 250 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[9] == 0)
			{
				_hand[9] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 200;
				_mc.Top = 408;
			}
			else if(_mc.Left >= 207 && _mc.Left <= 346 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[10] == 0)
			{
				_hand[10] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 296;
				_mc.Top = 408;
			}
			else if(_mc.Left >= 303 && _mc.Left <= 442 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[11] == 0)
			{
				_hand[11] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 392;
				_mc.Top = 408;
			}
			else if(_mc.Left >= 399 && _mc.Left <= 538 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[12] == 0)
			{
				_hand[12] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 488;
				_mc.Top = 408;
			}
			else if(_mc.Left >= 495 && _mc.Top >= 270 && _mc.Top <= 536 && _hand[13] == 0)
			{
				_hand[13] = ((_cy - 8) / 80 + 1) * 100 + (_cx - 8) / 48 + 2;
				_mc.Left = 584;
				_mc.Top = 408;
			}
			else
			{
                _mc.Visible = false;
				_mc.Left = _cx;
                _mc.Top = _cy;
                BringOrder(((_cy - 8) / 80) * 13 + (_cx - 8) / 48);
                _mc.Visible = true;
            }
            if (_hand[7] != 0 && _hand[8] != 0 && _hand[9] != 0 && _hand[10] != 0 && _hand[11] != 0 && _hand[12] != 0 && _hand[13] != 0)
                checkPokerHand();
            else
                hand.Text = "Click on a card and drag it to a position. Once all of the positions are filled your poker hand will be revealed.";
			_mc = null;
		}
        private void CardMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
            int card;
            for (card = 0; card < 52; card++)
            {
                if (sender.Equals(_cards[card]))
                {
                    break;
                }
            }
			for(int i = 7; i < 14; i++)
                if (_hand[i] != 0 && _hand[i] != _cardNum[card])
					RmvHand(_hand[i]);
            _mc = _cards[card];
			_mc.BringToFront();
			_mx = e.X;
			_my = e.Y;
            _cx = (card % 13) * 48 + 8;
            _cy = (card / 13) * 80 + 8;
			if(_mc.Top == 408 || _mc.Top == 400)
			{
				for(int i = 0; i < 7; i++)
					_hand[i] = 0;
				switch(_mc.Left)
				{
					case 8:
						_hand[7] = 0;
						break;
					case 104:
						_hand[8] = 0;
						break;
					case 200:
						_hand[9] = 0;
						break;
					case 296:
						_hand[10] = 0;
						break;
					case 392:
						_hand[11] = 0;
						break;
					case 488:
						_hand[12] = 0;
						break;
					case 584:
						_hand[13] = 0;
						break;
				}

            }
            //Make Sure You Change AllowDrop = True;
            DoDragDrop(_mc, DragDropEffects.All);
		}
		private void BringOrder(int num)
		{
            for (int i = num; i < 52; i++)
                _cards[i].BringToFront();
		}
		private void reset_Click(object sender, System.EventArgs e)
		{
			resetCards();
		}
		private void resetCards()
        {
            BringOrder(0);
            for (int i = 0; i < 14; i++)
            {
                if (i > 6)
                {
                    int index = (_hand[i] / 100 - 1) * 13 + _hand[i] % 100 - 2;
                    _cards[index].Visible = false;
                    _cards[index].Top = (index / 13) * 80 + 8;
                    _cards[index].Left = index % 13 * 48 + 8;
                    _cards[index].Visible = true;
                }
                _hand[i] = 0;
            }
			hand.Text = "Click on a card and drag it to a position. Once all of the positions are filled your poker hand will be revealed.";
		}
        private void checkSuit(int suit)
		{
			switch(suit)
			{
				case 1:		hand.Text += "Hearts";
					break;
				case 2:		hand.Text += "Clubs";
					break;
				case 3:		hand.Text += "Diamonds";
					break;
				case 4:		hand.Text += "Spades";
					break;
			}
		}
        private void checkCard(int card)
		{
			switch(card)
			{
				case 2:		hand.Text += "2";
					break;
				case 3:		hand.Text += "3";
					break;
				case 4:		hand.Text += "4";
					break;
				case 5:		hand.Text += "5";
					break;
				case 6:		hand.Text += "6";
					break;
				case 7:		hand.Text += "7";
					break;
				case 8:		hand.Text += "8";
					break;
				case 9:		hand.Text += "9";
					break;
				case 10:	hand.Text += "10";
					break;
				case 11:	hand.Text += "J";
					break;
				case 12:	hand.Text += "Q";
					break;
				case 13:	hand.Text += "K";
					break;
				case 14:	hand.Text += "A";
					break;
			}
		}
        private void sort()//selection sort
		{
			for(int i = 7; i < 13; i++)
			{
				int index = i;
				for(int j = i + 1; j < 14; j++)
					if(_hand[j] < _hand[index])
					{
						index = j;
					}
				int temp = _hand[index];
				_hand[index] = _hand[i];
				_hand[i] = temp;
			}
		}
        private void checkPokerHand()
		{
			for(int i = 0; i < 14; i++)
				_unsorted[i] = _hand[i];
			int card1 = _hand[7];
			int card2 = _hand[8];
			if(card2 % 100 > card1 % 100)
			{
				int temp = card1;
				card1 = card2;
				card2 = temp;
			}
			//_hand[14] = {poker hand, pair, high card, kicker 1, kicker 2, kicker 3, kicker 4, card1, card2, card3, card4, card5, card6, card7}; card1 = one of the player's cards; card2 = the other card;
			//card#: (1 = hearts; 2 = clubs; 3 = diamonds; 4 = spades) + (02 = 2 - 14 = A) (e.g. 205 = 5 of clubs)
			sort();//by suit
			//straight flush = 8
            if (_hand[8] / 100 == _hand[13] / 100 && _hand[8] % 100 == 2 && _hand[9] % 100 == 3 && _hand[10] % 100 == 4 && _hand[11] % 100 == 5 && _hand[13] % 100 == 14)
            {
                _hand[0] = 8;
                _hand[2] = _hand[11];
                _hand[3] = _hand[10];
                _hand[4] = _hand[9];
                _hand[5] = _hand[8];
                _hand[6] = _hand[13];
            }
            else if (_hand[7] / 100 == _hand[12] / 100 && _hand[7] % 100 == 2 && _hand[8] % 100 == 3 && _hand[9] % 100 == 4 && _hand[10] % 100 == 5 && _hand[12] % 100 == 14)
            {
                _hand[0] = 8;
                _hand[2] = _hand[10];
                _hand[3] = _hand[9];
                _hand[4] = _hand[8];
                _hand[5] = _hand[7];
                _hand[6] = _hand[12];
            }
            else if (_hand[7] / 100 == _hand[13] / 100 && _hand[7] % 100 == 2 && _hand[8] % 100 == 3 && _hand[9] % 100 == 4 && _hand[10] % 100 == 5 && _hand[13] % 100 == 14)
            {
                _hand[0] = 8;
                _hand[2] = _hand[10];
                _hand[3] = _hand[9];
                _hand[4] = _hand[8];
                _hand[5] = _hand[7];
                _hand[6] = _hand[13];
            }
            if (_hand[7] / 100 == _hand[11] / 100)
            {
                if (_hand[7] + 1 == _hand[8] && _hand[8] + 1 == _hand[9] && _hand[9] + 1 == _hand[10] && _hand[10] + 1 == _hand[11] || _hand[7] % 100 == 2 && _hand[8] % 100 == 3 && _hand[9] % 100 == 4 && _hand[10] % 100 == 5 && _hand[11] % 100 == 14)
                {
                    _hand[0] = 8;
                    if (_hand[10] % 100 == 5 && _hand[11] % 100 == 14)
                    {
                        _hand[2] = _hand[10];
                        _hand[3] = _hand[9];
                        _hand[4] = _hand[8];
                        _hand[5] = _hand[7];
                        _hand[6] = _hand[11];
                    }
                    else
                    {
                        _hand[2] = _hand[11];
                        _hand[3] = _hand[10];
                        _hand[4] = _hand[9];
                        _hand[5] = _hand[8];
                        _hand[6] = _hand[7];
                    }
                }
            }
            if (_hand[8] / 100 == _hand[12] / 100)
            {
                if (_hand[8] + 1 == _hand[9] && _hand[9] + 1 == _hand[10] && _hand[10] + 1 == _hand[11] && _hand[11] + 1 == _hand[12] || _hand[8] % 100 == 2 && _hand[9] % 100 == 3 && _hand[10] % 100 == 4 && _hand[11] % 100 == 5 && _hand[12] % 100 == 14)
                {
                    _hand[0] = 8;
                    if (_hand[11] % 100 == 5 && _hand[12] % 100 == 14)
                    {
                        _hand[2] = _hand[11];
                        _hand[3] = _hand[10];
                        _hand[4] = _hand[9];
                        _hand[5] = _hand[8];
                        _hand[6] = _hand[12];
                    }
                    else
                    {
                        _hand[2] = _hand[12];
                        _hand[3] = _hand[11];
                        _hand[4] = _hand[10];
                        _hand[5] = _hand[9];
                        _hand[6] = _hand[8];
                    }
                }
            }
			if(_hand[9] / 100 == _hand[13] / 100)
			{
                if (_hand[9] + 1 == _hand[10] && _hand[10] + 1 == _hand[11] && _hand[11] + 1 == _hand[12] && _hand[12] + 1 == _hand[13] || _hand[9] % 100 == 2 && _hand[10] % 100 == 3 && _hand[11] % 100 == 4 && _hand[12] % 100 == 5 && _hand[13] % 100 == 14)
                {
                    _hand[0] = 8;
                    if (_hand[12] % 100 == 5 && _hand[13] % 100 == 14)
                    {
				   	    _hand[2] = _hand[12];
                        _hand[3] = _hand[11];
                        _hand[4] = _hand[10];
                        _hand[5] = _hand[9];
                        _hand[6] = _hand[13];
                    }
                    else
                    {
					    _hand[2] = _hand[13];
                        _hand[3] = _hand[12];
                        _hand[4] = _hand[11];
                        _hand[5] = _hand[10];
                        _hand[6] = _hand[9];
                    }
                }
			}
            //straight flush = 8
            if (_hand[0] < 8)
            {
                for (int i = 0; i < 14; i++)
                    _hand[i] %= 100;
                sort();//by card number
            }
			//four = 7
			if(_hand[13] == _hand[10] && _hand[0] < 8)
			{
				_hand[0] = 7;
				_hand[1] = _hand[13];
				_hand[2] = _hand[9];
			}
            else if (_hand[12] == _hand[9] && _hand[0] < 8)
			{
				_hand[0] = 7;
				_hand[1] = _hand[12];
				_hand[2] = _hand[13];
			}
            else if (_hand[11] == _hand[8] && _hand[0] < 8)
			{
				_hand[0] = 7;
				_hand[1] = _hand[11];
				_hand[2] = _hand[13];
			}
            else if (_hand[10] == _hand[7] && _hand[0] < 8)
			{
				_hand[0] = 7;
				_hand[1] = _hand[10];
				_hand[2] = _hand[13];
			}//four = 7
			//full house = 6
            if (_hand[13] == _hand[11] && _hand[0] < 7)
			{
				if(_hand[10] == _hand[9])
				{
					_hand[0] = 6;
					_hand[1] = _hand[13];
                    _hand[2] = _hand[10];
				}
				else if(_hand[9] == _hand[8])
				{
					_hand[0] = 6;
					_hand[1] = _hand[13];
                    _hand[2] = _hand[9];
				}
				else if(_hand[8] == _hand[7])
				{
					_hand[0] = 6;
					_hand[1] = _hand[13];
                    _hand[2] = _hand[8];
				}
			}
            else if (_hand[12] == _hand[10] && _hand[0] < 7)
			{
				if(_hand[9] == _hand[8])
				{
					_hand[0] = 6;
					_hand[1] = _hand[12];
                    _hand[2] = _hand[9];
                    displayHand(card1, card2);
				}
				else if(_hand[8] == _hand[7])
				{
					_hand[0] = 6;
					_hand[1] = _hand[12];
                    _hand[2] = _hand[8];
				}
			}
            else if (_hand[11] == _hand[9] && _hand[0] < 7)
			{
				if(_hand[13] == _hand[12])
				{
					_hand[0] = 6;
					_hand[1] = _hand[11];
                    _hand[2] = _hand[13];
				}
				else if(_hand[8] == _hand[7])
				{
					_hand[0] = 6;
					_hand[1] = _hand[11];
                    _hand[2] = _hand[8];
				}
			}
            else if (_hand[10] == _hand[8] && _hand[0] < 7)
			{
				if(_hand[13] == _hand[12])
				{
					_hand[0] = 6;
					_hand[1] = _hand[10];
                    _hand[2] = _hand[13];
				}
				else if(_hand[12] == _hand[11])
				{
					_hand[0] = 6;
					_hand[1] = _hand[10];
                    _hand[2] = _hand[12];
				}
			}
            else if (_hand[9] == _hand[7] && _hand[0] < 7)
			{
				if(_hand[13] == _hand[12])
				{
					_hand[0] = 6;
					_hand[1] = _hand[9];
                    _hand[2] = _hand[13];
				}
				else if(_hand[12] == _hand[11])
				{
					_hand[0] = 6;
					_hand[1] = _hand[9];
                    _hand[2] = _hand[12];
				}
				else if(_hand[11] == _hand[10])
				{
					_hand[0] = 6;
					_hand[1] = _hand[9];
                    _hand[2] = _hand[11];
				}
			}//full house = 6
            if (_hand[0] < 6)
            {
                for (int i = 0; i < 14; i++)
                    _hand[i] = _unsorted[i];
                sort();//by suit
            }
            //flush = 5
            if (_hand[9] / 100 == _hand[13] / 100 && _hand[0] < 6)
            {
                _hand[0] = 5;
                _hand[2] = _hand[13];
                _hand[3] = _hand[12];
                _hand[4] = _hand[11];
                _hand[5] = _hand[10];
                _hand[6] = _hand[9];
            }
            else if (_hand[8] / 100 == _hand[12] / 100 && _hand[0] < 6)
            {
                _hand[0] = 5;
                _hand[2] = _hand[12];
                _hand[3] = _hand[11];
                _hand[4] = _hand[10];
                _hand[5] = _hand[9];
                _hand[6] = _hand[8];
            }
            else if (_hand[7] / 100 == _hand[11] / 100 && _hand[0] < 6)
            {
                _hand[0] = 5;
                _hand[2] = _hand[11];
                _hand[3] = _hand[10];
                _hand[4] = _hand[9];
                _hand[5] = _hand[8];
                _hand[6] = _hand[7];
            }//flush = 5
            if (_hand[0] < 5)
            {
            //low to high card
            //straight = 4
                for (int i = 0; i < 14; i++)
                    _hand[i] %= 100;
                sort();//by card number
                for (int a = 13; a > 10; a--)
                {
                    for (int b = a - 1; b > 9; b--)
                    {
                        for (int c = b - 1; c > 8; c--)
                        {
                            for (int d = c - 1; d > 7; d--)
                            {
                                for (int e = d - 1; e > 6; e--)
                                {
                                    if (_hand[e] + 1 == _hand[d] && _hand[d] + 1 == _hand[c] && _hand[c] + 1 == _hand[b] && _hand[b] + 1 == _hand[a])
                                    {
                                        _hand[0] = 4;
                                        _hand[2] = _hand[a];
                                        _hand[3] = _hand[b];
                                        _hand[4] = _hand[c];
                                        _hand[5] = _hand[d];
                                        _hand[6] = _hand[e];
                                    }
                                    else if (_hand[e] == 2 && _hand[d] == 3 && _hand[c] == 4 && _hand[b] == 5 && _hand[a] == 14)
                                    {
                                        _hand[0] = 4;
                                        _hand[2] = 5;
                                        _hand[3] = 4;
                                        _hand[4] = 3;
                                        _hand[5] = 2;
                                        _hand[6] = 14;
                                    }
                                }
                            }
                        }
                    }
                }
            }//straight = 4
            //three = 3
            if (_hand[13] == _hand[11] && _hand[0] < 4)
            {
                _hand[0] = 3;
                _hand[1] = _hand[13];
                _hand[2] = _hand[10];
                _hand[3] = _hand[9];
            }
            else if (_hand[12] == _hand[10] && _hand[0] < 4)
            {
                _hand[0] = 3;
                _hand[1] = _hand[12];
                _hand[2] = _hand[13];
                _hand[3] = _hand[9];
            }
            else if (_hand[11] == _hand[9] && _hand[0] < 4)
            {
                _hand[0] = 3;
                _hand[1] = _hand[11];
                _hand[2] = _hand[13];
                _hand[3] = _hand[12];
            }
            else if (_hand[10] == _hand[8] && _hand[0] < 4)
            {
                _hand[0] = 3;
                _hand[1] = _hand[10];
                _hand[2] = _hand[13];
                _hand[3] = _hand[12];
            }
            else if (_hand[9] == _hand[7] && _hand[0] < 4)
            {
                _hand[0] = 3;
                _hand[1] = _hand[9];
                _hand[2] = _hand[13];
                _hand[3] = _hand[12];
            }//three = 3
			//two pair = 2//pair = 1
            if (_hand[13] == _hand[12] && _hand[0] < 3)
			{
				if(_hand[11] == _hand[10])
				{
					_hand[0] = 2;
					_hand[1] = _hand[13];
					_hand[2] = _hand[11];
					_hand[3] = _hand[9];
				}
				else if(_hand[10] == _hand[9])
				{
					_hand[0] = 2;
					_hand[1] = _hand[13];
					_hand[2] = _hand[10];
					_hand[3] = _hand[11];
				}
				else if(_hand[9] == _hand[8])
				{
					_hand[0] = 2;
					_hand[1] = _hand[13];
					_hand[2] = _hand[9];
					_hand[3] = _hand[11];
				}
				else if(_hand[8] == _hand[7])
				{
					_hand[0] = 2;
					_hand[1] = _hand[13];
					_hand[2] = _hand[8];
					_hand[3] = _hand[11];
				}
				else
				{
					_hand[0] = 1;
					_hand[1] = _hand[13];
					_hand[2] = _hand[11];
					_hand[3] = _hand[10];
					_hand[4] = _hand[9];
				}
			}
            else if (_hand[12] == _hand[11] && _hand[0] < 3)
			{
				if(_hand[10] == _hand[9])
				{
					_hand[0] = 2;
					_hand[1] = _hand[12];
					_hand[2] = _hand[10];
					_hand[3] = _hand[13];
				}
				else if(_hand[9] == _hand[8])
				{
					_hand[0] = 2;
					_hand[1] = _hand[12];
					_hand[2] = _hand[9];
					_hand[3] = _hand[13];
				}
				else if(_hand[8] == _hand[7])
				{
					_hand[0] = 2;
					_hand[1] = _hand[12];
					_hand[2] = _hand[8];
					_hand[3] = _hand[13];
				}
				else
				{
					_hand[0] = 1;
					_hand[1] = _hand[12];
					_hand[2] = _hand[13];
					_hand[3] = _hand[10];
					_hand[4] = _hand[9];
				}
			}
            else if (_hand[11] == _hand[10] && _hand[0] < 3)
			{
				if(_hand[9] == _hand[8])
				{
					_hand[0] = 2;
					_hand[1] = _hand[11];
					_hand[2] = _hand[9];
					_hand[3] = _hand[13];
				}
				else if(_hand[8] == _hand[7])
				{
					_hand[0] = 2;
					_hand[1] = _hand[11];
					_hand[2] = _hand[8];
					_hand[3] = _hand[13];
				}
				else
				{
					_hand[0] = 1;
					_hand[1] = _hand[11];
					_hand[2] = _hand[13];
					_hand[3] = _hand[12];
					_hand[4] = _hand[9];
				}
			}
            else if (_hand[10] == _hand[9] && _hand[0] < 3)
			{
				if(_hand[8] == _hand[7])
				{
					_hand[0] = 2;
					_hand[1] = _hand[10];
					_hand[2] = _hand[8];
					_hand[3] = _hand[13];
				}
				else
				{
					_hand[0] = 1;
					_hand[1] = _hand[10];
					_hand[2] = _hand[13];
					_hand[3] = _hand[12];
					_hand[4] = _hand[11];
				}
			}
            else if (_hand[9] == _hand[8] && _hand[0] < 3)
            {
                _hand[0] = 1;
                _hand[1] = _hand[9];
                _hand[2] = _hand[13];
                _hand[3] = _hand[12];
                _hand[4] = _hand[11];
                displayHand(card1, card2);
            }
            else if (_hand[8] == _hand[7] && _hand[0] < 3)
            {

                _hand[0] = 1;
                _hand[1] = _hand[8];
                _hand[2] = _hand[13];
                _hand[3] = _hand[12];
                _hand[4] = _hand[11];
            }//two pair = 2//pair = 1
			//high card = 0
            if (_hand[0] == 0)
			{
				_hand[2] = _hand[13];
				_hand[3] = _hand[12];
				_hand[4] = _hand[11];
				_hand[5] = _hand[10];
				_hand[6] = _hand[9];
            }
            displayHand(card1, card2);
			//high card = 0
			
			for(int i = 0; i < 14; i++)
				_hand[i] = _unsorted[i];
		}
        private void displayHand(int card1,int card2)
		{
			hand.Text = "";
			switch(_hand[0])
			{
				case 0: 
					for(int i = 2; i < 7; i++)
					{
						for(int j = 7; j < 14; j++)
						{
							if(_hand[i] == _unsorted[j] % 100)
								DispHand(_unsorted[j]);
						}
					}
					checkCard(_hand[2]);
					hand.Text += " high";
					if(card1 % 100 >= _hand[6])
					{
						if(card1 % 100 == _hand[2])
						{
							if(card2 % 100 >= _hand[6])
							{
								hand.Text += "; ";
								checkCard(card2 % 100);
								hand.Text +=" kicker";
							}
						}
						else
						{
							hand.Text += "; ";
							checkCard(card1 % 100);
							if(card2 % 100 >= _hand[6] && card2 % 100 != _hand[2])
							{
								hand.Text += ", ";
								checkCard(card2 % 100);
								hand.Text += " kickers";
							}
							else
							{
								hand.Text += " kicker";
							}
						}
					}
					break;
				case 1: 
					for(int i = 1; i < 5; i++)
					{
						for(int j = 7; j < 14; j++)
							if(_hand[i] == _unsorted[j] % 100)
								DispHand(_unsorted[j]);
					}
					hand.Text += "Pair of ";
					checkCard(_hand[1]);
					hand.Text += "s";
					if(card1 % 100 >= _hand[4])
					{
						if(card1 % 100 == _hand[1])
						{
							if(card2 % 100 >= _hand[4] && card2 % 100 != _hand[1])
							{
								hand.Text += "; ";
								checkCard(card2 % 100);
								hand.Text += " kicker";
							}
						}
						else
						{		
							hand.Text += "; ";
							checkCard(card1 % 100);
							if(card2 % 100 >= _hand[4] && card2 % 100 != _hand[1])
							{
								hand.Text += ", ";
								checkCard(card2 % 100);
								hand.Text += " kickers";
							}
							else
							{
								hand.Text += " kicker";
							}
						}
					}
					break;
				case 2:
					for(int i = 1; i < 3; i++)
					{
						for(int j = 7; j < 14; j++)
							if(_hand[i] == _unsorted[j] % 100)
								DispHand(_unsorted[j]);
					}
					for(int i = 7; i < 14; i++)
					{
						if(_hand[3] == _unsorted[i] % 100)
						{
							DispHand(_unsorted[i]);
							break;
						}
					}
					hand.Text += "Two pair ";
					checkCard(_hand[1]);
					hand.Text += "s and ";
					checkCard(_hand[2]);
					hand.Text += "s";
					if(card1		 % 100 == _hand[3])
					{
						hand.Text += "; ";
						checkCard(card1 % 100);
						hand.Text += " kicker";
					}
					else if(card2 % 100 == _hand[3])
					{
						hand.Text += "; ";
						checkCard(card2 % 100);
						hand.Text += " kicker";
					}
					break;
				case 3:
					for(int i = 1; i < 5; i++)
					{
						for(int j = 7; j < 14; j++)
							if(_hand[i] == _unsorted[j] % 100)
								DispHand(_unsorted[j]);
					}
					hand.Text += "Three of a kind ";
					checkCard(_hand[1]);
					hand.Text += "s";
					if(card1 % 100 >= _hand[3])
					{
						if(card1 % 100 == _hand[1])
						{
							if(card2 % 100 >= _hand[3])
							{
								hand.Text += "; ";
								checkCard(card2 % 100);
								hand.Text += " kicker";
							}
						}
						else
						{
							hand.Text += "; ";
							checkCard(card1 % 100);
							if(card2 % 100 >= _hand[3] && card2 % 100 != _hand[1])
							{
								hand.Text += ", ";
								checkCard(card2 % 100);
								hand.Text += " kickers";
							}
							else
							{
								hand.Text += " kicker";
							}
						}
					}
					break;
				case 4:
					for(int i = 2; i < 7; i++)
					{
						for(int j = 7; j < 14; j++)
						{
							if(_hand[i] == _unsorted[j] % 100)
							{
								DispHand(_unsorted[j]);
								break;
							}
						}
					}
					checkCard(_hand[2]);
					hand.Text += " high straight";
					break;
				case 5:
					for(int i = 2; i < 7; i++)
					{
						for(int j = 7; j < 14; j++)
						{
							if(_hand[i] == _unsorted[j])
								DispHand(_unsorted[j]);
						}
					}
					checkCard(_hand[2] % 100);
					hand.Text += " high flush of ";
					checkSuit(_hand[2] / 100);
					if(card1 / 100 == _hand[6] / 100 && card1 > _hand[6] && card1 != _hand[2])
					{
						hand.Text += "; ";
						checkCard(card1 % 100);
						if(card2 / 100 == _hand[6] / 100 && card2 > _hand[6] && card2 != _hand[2])
						{
							hand.Text += ", ";
							checkCard(card2 % 100);
							hand.Text += " kickers";
						}
						else
						{
							hand.Text += " kicker";
						}
					}
					break;
				case 6:
					for(int i = 7; i < 14; i++)
					{
						if(_hand[1] == _unsorted[i] % 100)
							DispHand(_unsorted[i]);
					}
					int temp = 0;
					for(int i = 7; i < 14; i++)
					{
						if(_hand[2] == _unsorted[i] % 100 && temp < 2)
						{
							DispHand(_unsorted[i]);
							temp++;
						}
					}
					hand.Text += "Full house ";
					checkCard(_hand[1]);
					hand.Text += "s over ";
					checkCard(_hand[2]);
					hand.Text += "s";
					break;
				case 7: 
					for(int i = 7; i < 14; i++)
					{
						if(_hand[1] == _unsorted[i] % 100)
							DispHand(_unsorted[i]);
					}
					for(int i = 7; i < 14; i++)
					{
						if(_hand[2] == _unsorted[i] % 100)
						{
							DispHand(_unsorted[i]);
							break;
						}
					}
					hand.Text += "Four of a kind ";
					checkCard(_hand[1]);
					hand.Text += "s";
					if(card1 % 100 == _hand[2])
					{
						hand.Text += "; ";
						checkCard(card1 % 100);
						hand.Text += " kicker";
					}
					else if(card2 % 100 == _hand[2])
					{
						hand.Text += "; ";
						checkCard(card2 % 100);
						hand.Text += " kicker";
					}
					break;
				case 8: 
					for(int i = 2; i < 7; i++)
					{
						for(int j = 7; j < 14; j++)
						{
							if(_hand[i] == _unsorted[j])
							{
								DispHand(_unsorted[j]);
								break;
							}
						}
					}
					if (_hand[2] % 100 == 14)
					{
						hand.Text += "Royal flush of ";
						checkSuit(_hand[2] / 100);
					}
					else
					{
						hand.Text += "Straight flush ";
						checkCard(_hand[2] % 100);
						hand.Text += " high of ";
						checkSuit(_hand[2] / 100);
					}
					break;
			}
		}
		private void num2picture(int num)
		{
			switch(num)
			{
				case 102:	_mc = h2;
					break;
				case 103:	_mc = h3;
					break;
				case 104:	_mc = h4;
					break;
				case 105:	_mc = h5;
					break;
				case 106:	_mc = h6;
					break;
				case 107:	_mc = h7;
					break;
				case 108:	_mc = h8;
					break;
				case 109:	_mc = h9;
					break;
				case 110:	_mc = h10;
					break;
				case 111:	_mc = hj;
					break;
				case 112:	_mc = hq;
					break;
				case 113:	_mc = hk;
					break;
				case 114:	_mc = ha;
					break;
				case 202:	_mc = c2;
					break;
				case 203:	_mc = c3;
					break;
				case 204:	_mc = c4;
					break;
				case 205:	_mc = c5;
					break;
				case 206:	_mc = c6;
					break;
				case 207:	_mc = c7;
					break;
				case 208:	_mc = c8;
					break;
				case 209:	_mc = c9;
					break;
				case 210:	_mc = c10;
					break;
				case 211:	_mc = cj;
					break;
				case 212:	_mc = cq;
					break;
				case 213:	_mc = ck;
					break;
				case 214:	_mc = ca;
					break;
				case 302:	_mc = d2;
					break;
				case 303:	_mc = d3;
					break;
				case 304:	_mc = d4;
					break;
				case 305:	_mc = d5;
					break;
				case 306:	_mc = d6;
					break;
				case 307:	_mc = d7;
					break;
				case 308:	_mc = d8;
					break;
				case 309:	_mc = d9;
					break;
				case 310:	_mc = d10;
					break;
				case 311:	_mc = dj;
					break;
				case 312:	_mc = dq;
					break;
				case 313:	_mc = dk;
					break;
				case 314:	_mc = da;
					break;
				case 402:	_mc = s2;
					break;
				case 403:	_mc = s3;
					break;
				case 404:	_mc = s4;
					break;
				case 405:	_mc = s5;
					break;
				case 406:	_mc = s6;
					break;
				case 407:	_mc = s7;
					break;
				case 408:	_mc = s8;
					break;
				case 409:	_mc = s9;
					break;
				case 410:	_mc = s10;
					break;
				case 411:	_mc = sj;
					break;
				case 412:	_mc = sq;
					break;
				case 413:	_mc = sk;
					break;
				case 414:	_mc = sa;
					break;
			}
		}
		private void random_Click(object sender, System.EventArgs e)
		{
			if(_hand[7] != 0 && _hand[8] != 0 && _hand[9] != 0 && _hand[10] != 0 && _hand[11] != 0 && _hand[12] != 0 && _hand[13] != 0)
			{
				resetCards();
			}
			else
			{
				for(int i = 0; i < 7; i++)
					_hand[i] = 0;
			}
			for(int i = 7; i < 14; i++)
			{
				Random randClass = new Random((int)System.DateTime.Now.Ticks);
				int rand;
				do
				{
					rand = randClass.Next(1,5) * 100 + randClass.Next(2,15);
					num2picture(rand);
				}while(_mc.Top == 408);
				if(_hand[i] == 0)
				{
					_hand[i] = rand;
                    _mc.Visible = false;
					_mc.BringToFront();
					_mc.Left = (i - 7) * 96 + 8;
					_mc.Top = 408;
                    _mc.Visible = true;
				}
			}
			_mc = null;
			checkPokerHand();
		}
		private void DispHand(int card)
		{
			num2picture(card);
			_mc.Top = 400;
			_mc = null;
		}
		private void RmvHand(int card)
		{
			num2picture(card);
			_mc.Top = 408;
			_mc = null;
		}
	}
}
