namespace Ferry_System
{
    partial class FrmFerryManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.lblRegNumber = new System.Windows.Forms.Label();
            this.lblPassengerNumber = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.txtPassengerNumber = new System.Windows.Forms.TextBox();
            this.nudVehicleIndex = new System.Windows.Forms.NumericUpDown();
            this.btnExamine = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnFindbyReg = new System.Windows.Forms.Button();
            this.btnFindbyDriver = new System.Windows.Forms.Button();
            this.btnFindbyVehicle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(224, 129);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(39, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Output";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(12, 70);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 53);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Vehicle";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Location = new System.Drawing.Point(12, 129);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 53);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(12, 188);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 53);
            this.btnCount.TabIndex = 4;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(12, 247);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 53);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(242, 31);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(66, 13);
            this.lblDriverName.TabIndex = 6;
            this.lblDriverName.Text = "Driver Name";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Location = new System.Drawing.Point(382, 31);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(69, 13);
            this.lblVehicleType.TabIndex = 7;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // lblRegNumber
            // 
            this.lblRegNumber.AutoSize = true;
            this.lblRegNumber.Location = new System.Drawing.Point(521, 31);
            this.lblRegNumber.Name = "lblRegNumber";
            this.lblRegNumber.Size = new System.Drawing.Size(67, 13);
            this.lblRegNumber.TabIndex = 8;
            this.lblRegNumber.Text = "Reg Number";
            // 
            // lblPassengerNumber
            // 
            this.lblPassengerNumber.AutoSize = true;
            this.lblPassengerNumber.Location = new System.Drawing.Point(660, 31);
            this.lblPassengerNumber.Name = "lblPassengerNumber";
            this.lblPassengerNumber.Size = new System.Drawing.Size(97, 13);
            this.lblPassengerNumber.TabIndex = 9;
            this.lblPassengerNumber.Text = "Passenger Number";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(218, 47);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(100, 20);
            this.txtDriverName.TabIndex = 10;
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Location = new System.Drawing.Point(367, 47);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(100, 20);
            this.txtVehicleType.TabIndex = 11;
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(506, 47);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegNumber.TabIndex = 12;
            // 
            // txtPassengerNumber
            // 
            this.txtPassengerNumber.Location = new System.Drawing.Point(663, 47);
            this.txtPassengerNumber.Name = "txtPassengerNumber";
            this.txtPassengerNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPassengerNumber.TabIndex = 13;
            // 
            // nudVehicleIndex
            // 
            this.nudVehicleIndex.Location = new System.Drawing.Point(245, 323);
            this.nudVehicleIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudVehicleIndex.Name = "nudVehicleIndex";
            this.nudVehicleIndex.Size = new System.Drawing.Size(120, 20);
            this.nudVehicleIndex.TabIndex = 14;
            this.nudVehicleIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExamine
            // 
            this.btnExamine.Location = new System.Drawing.Point(148, 312);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(75, 39);
            this.btnExamine.TabIndex = 15;
            this.btnExamine.Text = "Examine Vehicle";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(12, 306);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(75, 45);
            this.btnPeek.TabIndex = 16;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            // 
            // btnFindbyReg
            // 
            this.btnFindbyReg.Location = new System.Drawing.Point(663, 140);
            this.btnFindbyReg.Name = "btnFindbyReg";
            this.btnFindbyReg.Size = new System.Drawing.Size(75, 34);
            this.btnFindbyReg.TabIndex = 17;
            this.btnFindbyReg.Text = "Find by Reg";
            this.btnFindbyReg.UseVisualStyleBackColor = true;
            this.btnFindbyReg.Click += new System.EventHandler(this.btnFindbyReg_Click);
            // 
            // btnFindbyDriver
            // 
            this.btnFindbyDriver.Location = new System.Drawing.Point(663, 188);
            this.btnFindbyDriver.Name = "btnFindbyDriver";
            this.btnFindbyDriver.Size = new System.Drawing.Size(75, 37);
            this.btnFindbyDriver.TabIndex = 18;
            this.btnFindbyDriver.Text = "Find By Driver";
            this.btnFindbyDriver.UseVisualStyleBackColor = true;
            this.btnFindbyDriver.Click += new System.EventHandler(this.btnFindbyDriver_Click);
            // 
            // btnFindbyVehicle
            // 
            this.btnFindbyVehicle.Location = new System.Drawing.Point(663, 247);
            this.btnFindbyVehicle.Name = "btnFindbyVehicle";
            this.btnFindbyVehicle.Size = new System.Drawing.Size(75, 35);
            this.btnFindbyVehicle.TabIndex = 19;
            this.btnFindbyVehicle.Text = "Find by Vehicle";
            this.btnFindbyVehicle.UseVisualStyleBackColor = true;
            this.btnFindbyVehicle.Click += new System.EventHandler(this.btnFindbyVehicle_Click);
            // 
            // FrmFerryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFindbyVehicle);
            this.Controls.Add(this.btnFindbyDriver);
            this.Controls.Add(this.btnFindbyReg);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnExamine);
            this.Controls.Add(this.nudVehicleIndex);
            this.Controls.Add(this.txtPassengerNumber);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.txtDriverName);
            this.Controls.Add(this.lblPassengerNumber);
            this.Controls.Add(this.lblRegNumber);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblOutput);
            this.Name = "FrmFerryManagement";
            this.Text = "FrmFerryManagement";
            ((System.ComponentModel.ISupportInitialize)(this.nudVehicleIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.Label lblRegNumber;
        private System.Windows.Forms.Label lblPassengerNumber;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.TextBox txtPassengerNumber;
        private System.Windows.Forms.NumericUpDown nudVehicleIndex;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnFindbyReg;
        private System.Windows.Forms.Button btnFindbyDriver;
        private System.Windows.Forms.Button btnFindbyVehicle;
    }
}