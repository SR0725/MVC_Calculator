
namespace homework1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._textBox = new System.Windows.Forms.TextBox();
            this._buttonClear = new System.Windows.Forms.Button();
            this._buttonClearEntry = new System.Windows.Forms.Button();
            this._buttonNine = new System.Windows.Forms.Button();
            this._buttonEight = new System.Windows.Forms.Button();
            this._buttonPlus = new System.Windows.Forms.Button();
            this._buttonSeven = new System.Windows.Forms.Button();
            this._buttonSix = new System.Windows.Forms.Button();
            this._buttonFive = new System.Windows.Forms.Button();
            this._buttonMinus = new System.Windows.Forms.Button();
            this._buttonFour = new System.Windows.Forms.Button();
            this._buttonThree = new System.Windows.Forms.Button();
            this._buttonTwo = new System.Windows.Forms.Button();
            this._buttonMultiply = new System.Windows.Forms.Button();
            this._buttonOne = new System.Windows.Forms.Button();
            this._buttonEqual = new System.Windows.Forms.Button();
            this._buttonDot = new System.Windows.Forms.Button();
            this._buttonDivide = new System.Windows.Forms.Button();
            this._buttonZero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Location = new System.Drawing.Point(12, 12);
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(251, 22);
            this._textBox.TabIndex = 0;
            // 
            // _buttonClear
            // 
            this._buttonClear.Location = new System.Drawing.Point(198, 51);
            this._buttonClear.Name = "_buttonClear";
            this._buttonClear.Size = new System.Drawing.Size(65, 41);
            this._buttonClear.TabIndex = 2;
            this._buttonClear.Text = "C";
            this._buttonClear.UseVisualStyleBackColor = true;
            this._buttonClear.Click += new System.EventHandler(this.ClickClearButton);
            // 
            // _buttonClearEntry
            // 
            this._buttonClearEntry.Location = new System.Drawing.Point(136, 51);
            this._buttonClearEntry.Name = "_buttonClearEntry";
            this._buttonClearEntry.Size = new System.Drawing.Size(56, 41);
            this._buttonClearEntry.TabIndex = 4;
            this._buttonClearEntry.Text = "CE";
            this._buttonClearEntry.UseVisualStyleBackColor = true;
            this._buttonClearEntry.Click += new System.EventHandler(this.ClickClearEntryButton);
            // 
            // _buttonNine
            // 
            this._buttonNine.Location = new System.Drawing.Point(136, 98);
            this._buttonNine.Name = "_buttonNine";
            this._buttonNine.Size = new System.Drawing.Size(56, 41);
            this._buttonNine.TabIndex = 8;
            this._buttonNine.Text = "9";
            this._buttonNine.UseVisualStyleBackColor = true;
            this._buttonNine.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonEight
            // 
            this._buttonEight.Location = new System.Drawing.Point(74, 98);
            this._buttonEight.Name = "_buttonEight";
            this._buttonEight.Size = new System.Drawing.Size(56, 41);
            this._buttonEight.TabIndex = 7;
            this._buttonEight.Text = "8";
            this._buttonEight.UseVisualStyleBackColor = true;
            this._buttonEight.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonPlus
            // 
            this._buttonPlus.Location = new System.Drawing.Point(198, 98);
            this._buttonPlus.Name = "_buttonPlus";
            this._buttonPlus.Size = new System.Drawing.Size(65, 41);
            this._buttonPlus.TabIndex = 6;
            this._buttonPlus.Text = "+";
            this._buttonPlus.UseVisualStyleBackColor = true;
            this._buttonPlus.Click += new System.EventHandler(this.ClickCalculateOperatorButton);
            // 
            // _buttonSeven
            // 
            this._buttonSeven.Location = new System.Drawing.Point(12, 98);
            this._buttonSeven.Name = "_buttonSeven";
            this._buttonSeven.Size = new System.Drawing.Size(56, 41);
            this._buttonSeven.TabIndex = 5;
            this._buttonSeven.Text = "7";
            this._buttonSeven.UseVisualStyleBackColor = true;
            this._buttonSeven.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonSix
            // 
            this._buttonSix.Location = new System.Drawing.Point(136, 145);
            this._buttonSix.Name = "_buttonSix";
            this._buttonSix.Size = new System.Drawing.Size(56, 41);
            this._buttonSix.TabIndex = 12;
            this._buttonSix.Text = "6";
            this._buttonSix.UseVisualStyleBackColor = true;
            this._buttonSix.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonFive
            // 
            this._buttonFive.Location = new System.Drawing.Point(74, 145);
            this._buttonFive.Name = "_buttonFive";
            this._buttonFive.Size = new System.Drawing.Size(56, 41);
            this._buttonFive.TabIndex = 11;
            this._buttonFive.Text = "5";
            this._buttonFive.UseVisualStyleBackColor = true;
            this._buttonFive.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonMinus
            // 
            this._buttonMinus.Location = new System.Drawing.Point(198, 145);
            this._buttonMinus.Name = "_buttonMinus";
            this._buttonMinus.Size = new System.Drawing.Size(65, 41);
            this._buttonMinus.TabIndex = 10;
            this._buttonMinus.Text = "-";
            this._buttonMinus.UseVisualStyleBackColor = true;
            this._buttonMinus.Click += new System.EventHandler(this.ClickCalculateOperatorButton);
            // 
            // _buttonFour
            // 
            this._buttonFour.Location = new System.Drawing.Point(12, 145);
            this._buttonFour.Name = "_buttonFour";
            this._buttonFour.Size = new System.Drawing.Size(56, 41);
            this._buttonFour.TabIndex = 9;
            this._buttonFour.Text = "4";
            this._buttonFour.UseVisualStyleBackColor = true;
            this._buttonFour.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonThree
            // 
            this._buttonThree.Location = new System.Drawing.Point(136, 192);
            this._buttonThree.Name = "_buttonThree";
            this._buttonThree.Size = new System.Drawing.Size(56, 41);
            this._buttonThree.TabIndex = 16;
            this._buttonThree.Text = "3";
            this._buttonThree.UseVisualStyleBackColor = true;
            this._buttonThree.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonTwo
            // 
            this._buttonTwo.Location = new System.Drawing.Point(74, 192);
            this._buttonTwo.Name = "_buttonTwo";
            this._buttonTwo.Size = new System.Drawing.Size(56, 41);
            this._buttonTwo.TabIndex = 15;
            this._buttonTwo.Text = "2";
            this._buttonTwo.UseVisualStyleBackColor = true;
            this._buttonTwo.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonMultiply
            // 
            this._buttonMultiply.Location = new System.Drawing.Point(198, 192);
            this._buttonMultiply.Name = "_buttonMultiply";
            this._buttonMultiply.Size = new System.Drawing.Size(65, 41);
            this._buttonMultiply.TabIndex = 14;
            this._buttonMultiply.Text = "*";
            this._buttonMultiply.UseVisualStyleBackColor = true;
            this._buttonMultiply.Click += new System.EventHandler(this.ClickCalculateOperatorButton);
            // 
            // _buttonOne
            // 
            this._buttonOne.Location = new System.Drawing.Point(12, 192);
            this._buttonOne.Name = "_buttonOne";
            this._buttonOne.Size = new System.Drawing.Size(56, 41);
            this._buttonOne.TabIndex = 13;
            this._buttonOne.Text = "1";
            this._buttonOne.UseVisualStyleBackColor = true;
            this._buttonOne.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonEqual
            // 
            this._buttonEqual.Location = new System.Drawing.Point(136, 239);
            this._buttonEqual.Name = "_buttonEqual";
            this._buttonEqual.Size = new System.Drawing.Size(56, 41);
            this._buttonEqual.TabIndex = 20;
            this._buttonEqual.Text = "=";
            this._buttonEqual.UseVisualStyleBackColor = true;
            this._buttonEqual.Click += new System.EventHandler(this.ClickEqualOperatorButton);
            // 
            // _buttonDot
            // 
            this._buttonDot.Location = new System.Drawing.Point(74, 239);
            this._buttonDot.Name = "_buttonDot";
            this._buttonDot.Size = new System.Drawing.Size(56, 41);
            this._buttonDot.TabIndex = 19;
            this._buttonDot.Text = ".";
            this._buttonDot.UseVisualStyleBackColor = true;
            this._buttonDot.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // _buttonDivide
            // 
            this._buttonDivide.Location = new System.Drawing.Point(198, 239);
            this._buttonDivide.Name = "_buttonDivide";
            this._buttonDivide.Size = new System.Drawing.Size(65, 41);
            this._buttonDivide.TabIndex = 18;
            this._buttonDivide.Text = "/";
            this._buttonDivide.UseVisualStyleBackColor = true;
            this._buttonDivide.Click += new System.EventHandler(this.ClickCalculateOperatorButton);
            // 
            // _buttonZero
            // 
            this._buttonZero.Location = new System.Drawing.Point(12, 239);
            this._buttonZero.Name = "_buttonZero";
            this._buttonZero.Size = new System.Drawing.Size(56, 41);
            this._buttonZero.TabIndex = 17;
            this._buttonZero.Text = "0";
            this._buttonZero.UseVisualStyleBackColor = true;
            this._buttonZero.Click += new System.EventHandler(this.ClickNumberButton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 307);
            this.Controls.Add(this._buttonEqual);
            this.Controls.Add(this._buttonDot);
            this.Controls.Add(this._buttonDivide);
            this.Controls.Add(this._buttonZero);
            this.Controls.Add(this._buttonThree);
            this.Controls.Add(this._buttonTwo);
            this.Controls.Add(this._buttonMultiply);
            this.Controls.Add(this._buttonOne);
            this.Controls.Add(this._buttonSix);
            this.Controls.Add(this._buttonFive);
            this.Controls.Add(this._buttonMinus);
            this.Controls.Add(this._buttonFour);
            this.Controls.Add(this._buttonNine);
            this.Controls.Add(this._buttonEight);
            this.Controls.Add(this._buttonPlus);
            this.Controls.Add(this._buttonSeven);
            this.Controls.Add(this._buttonClearEntry);
            this.Controls.Add(this._buttonClear);
            this.Controls.Add(this._textBox);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _buttonClear;
        private System.Windows.Forms.Button _buttonClearEntry;
        private System.Windows.Forms.Button _buttonNine;
        private System.Windows.Forms.Button _buttonEight;
        private System.Windows.Forms.Button _buttonPlus;
        private System.Windows.Forms.Button _buttonSeven;
        private System.Windows.Forms.Button _buttonSix;
        private System.Windows.Forms.Button _buttonFive;
        private System.Windows.Forms.Button _buttonMinus;
        private System.Windows.Forms.Button _buttonFour;
        private System.Windows.Forms.Button _buttonThree;
        private System.Windows.Forms.Button _buttonTwo;
        private System.Windows.Forms.Button _buttonMultiply;
        private System.Windows.Forms.Button _buttonOne;
        private System.Windows.Forms.Button _buttonEqual;
        private System.Windows.Forms.Button _buttonDot;
        private System.Windows.Forms.Button _buttonDivide;
        private System.Windows.Forms.Button _buttonZero;
    }
}

