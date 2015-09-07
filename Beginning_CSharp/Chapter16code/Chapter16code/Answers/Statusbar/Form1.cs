﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manual_Menus
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();

      fontsToolStripComboBox.SelectedIndex = 0;
    }

    private void showHelpMenuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      ToolStripMenuItem item = (ToolStripMenuItem)sender;
      helpToolStripMenuItem.Visible = item.Checked;
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      richTextBoxText.Text = "";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        richTextBoxText.LoadFile(@"Example.rtf");
      }
      catch { }
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        richTextBoxText.SaveFile("Example.rtf");
      }
      catch { }
    }

    private void boldToolStripButton_CheckedChanged(object sender, EventArgs e)
    {
      Font oldFont, newFont;

      bool checkState = ((ToolStripButton)sender).Checked;
      oldFont = this.richTextBoxText.SelectionFont;

      if (!checkState)
        newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
      else
        newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

      richTextBoxText.SelectionFont = newFont;
      richTextBoxText.Focus();

      boldToolStripMenuItem.CheckedChanged -= new
EventHandler(boldToolStripMenuItem_CheckedChanged);
      boldToolStripMenuItem.Checked = checkState;
      boldToolStripMenuItem.CheckedChanged += new
EventHandler(boldToolStripMenuItem_CheckedChanged);

         //StatusBar
         if (!checkState)
            toolStripStatusLabelBold.Font = new Font(toolStripStatusLabelBold.Font, toolStripStatusLabelBold.Font.Style & ~FontStyle.Bold);
         else
            toolStripStatusLabelBold.Font = new Font(toolStripStatusLabelBold.Font, toolStripStatusLabelBold.Font.Style | FontStyle.Bold);
    }

    private void italicToolStripButton_CheckedChanged(object sender, EventArgs e)
    {
      Font oldFont, newFont;

      bool checkState = ((ToolStripButton)sender).Checked;
      oldFont = this.richTextBoxText.SelectionFont;

      if (!checkState)
        newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
      else
        newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

      richTextBoxText.SelectionFont = newFont;
      richTextBoxText.Focus();

      italicToolStripMenuItem.CheckedChanged -= new
EventHandler(italicToolStripMenuItem_CheckedChanged);
      italicToolStripMenuItem.Checked = checkState;
      italicToolStripMenuItem.CheckedChanged += new
EventHandler(italicToolStripMenuItem_CheckedChanged);
//StatusBar
         if (!checkState)
            toolStripStatusLabelItalic.Font = new Font(toolStripStatusLabelItalic.Font, toolStripStatusLabelItalic.Font.Style & ~FontStyle.Italic);
         else
            toolStripStatusLabelItalic.Font = new Font(toolStripStatusLabelItalic.Font, toolStripStatusLabelItalic.Font.Style | FontStyle.Italic);

    }

    private void UnderlineToolStripButton_CheckedChanged(object sender, EventArgs e)
    {
      Font oldFont, newFont;

      bool checkState = ((ToolStripButton)sender).Checked;
      oldFont = this.richTextBoxText.SelectionFont;

      if (!checkState)
        newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
      else
        newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

      richTextBoxText.SelectionFont = newFont;
      richTextBoxText.Focus();

      underlineToolStripMenuItem.CheckedChanged -= new
EventHandler(underlineToolStripMenuItem_CheckedChanged);
      underlineToolStripMenuItem.Checked = checkState;
      underlineToolStripMenuItem.CheckedChanged += new
EventHandler(underlineToolStripMenuItem_CheckedChanged);

//StatusBar
         if (!checkState)
           toolStripStatusLabelUnderline.Font = new Font(toolStripStatusLabelUnderline.Font, toolStripStatusLabelItalic.Font.Style & ~FontStyle.Underline);
         else
           toolStripStatusLabelUnderline.Font = new Font(toolStripStatusLabelUnderline.Font, toolStripStatusLabelItalic.Font.Style | FontStyle.Underline);
    }

    private void boldToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      boldToolStripButton.Checked = boldToolStripMenuItem.Checked;
    }

    private void italicToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      italicToolStripButton.Checked = italicToolStripMenuItem.Checked;
    }

    private void underlineToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
    {
      underlineToolStripButton.Checked = underlineToolStripMenuItem.Checked;
    }

    private void fontsToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
      Font newFont = null;

      if (richTextBoxText.SelectionFont == null)
        newFont = new Font(text, richTextBoxText.Font.Size);
      else
        newFont = new Font(text, richTextBoxText.SelectionFont.Size,
                              richTextBoxText.SelectionFont.Style);
      richTextBoxText.SelectionFont = newFont;
    }

    private void richTextBoxText_TextChanged(object sender, EventArgs e)
    {
      toolStripStatusLabelText.Text = "Number of characters: " +
      richTextBoxText.Text.Length;
    }

    private void toolStripStatusLabelItalic_Click(object sender, EventArgs e)
    {
      italicToolStripButton.Checked = !italicToolStripButton.Checked;
    }

    private void toolStripStatusLabelUnderline_Click(object sender, EventArgs e)
    {
      underlineToolStripButton.Checked = !underlineToolStripButton.Checked;
    }

    private void toolStripStatusLabelBold_Click(object sender, EventArgs e)
    {
      boldToolStripButton.Checked = !boldToolStripButton.Checked;
    }
  }
}
