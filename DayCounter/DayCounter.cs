using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayCounter.Models;

namespace DayCounter
{
    public partial class frmDayCounter : Form
    {
        private TimeZoneInfo _timeZone1 = null;
        private TimeZoneInfo _timeZone2 = null;

        public frmDayCounter()
        {
            InitializeComponent();

            // Require that the settings have been configured.
            while (String.IsNullOrWhiteSpace(Config.SinceDate))
                ShowOptionsDialog();

            RefreshOutput();
        }

        private void RefreshOutput()
        {
            // Since date.
            var sinceDate = Convert.ToDateTime(Config.SinceDate);
            var sinceTotalDays = Convert.ToInt32(Math.Floor((DateTime.Now - sinceDate).TotalDays));

            if (sinceTotalDays > 0)
                lblDaysSince.Text = String.Format("It's been {0} days since {1}.", sinceTotalDays, sinceDate.ToLongDateString());
            else if (sinceTotalDays == 0)
                lblDaysSince.Text = String.Format("Today is the day of the since date, {0}.", sinceDate.ToLongDateString());
            else
                lblDaysSince.Text = "Error: the since date is in the future.";

            // Countdown date.
            var countdownDateEnabled = Convert.ToBoolean(Config.CountdownDateEnabled);

            if (countdownDateEnabled)
            {
                grpDateCountdown.Visible = true;

                var countdownDate = Convert.ToDateTime(Config.CountdownDate);
                var countdownTotalDays = Math.Ceiling((countdownDate - DateTime.Now).TotalDays);
                var countdownDifference = DateTime.Compare(countdownDate, DateTime.Now);

                if (countdownDifference > 0)
                    lblDateCountdown.Text = String.Format("There are {0} days left until {1}.", countdownTotalDays, countdownDate.ToLongDateString());
                else if (countdownDate.Date == DateTime.Now.Date)
                    lblDateCountdown.Text = String.Format("Today is the day of the countdown date, {0}.", countdownDate.ToLongDateString());
                else
                    lblDateCountdown.Text = String.Format("Today is pass the countdown date, {0}, which was {1} days ago.", countdownDate.ToLongDateString(), Convert.ToInt32(Math.Floor((DateTime.Now - countdownDate).TotalDays)));
            }
            else
            {
                grpDateCountdown.Visible = false;
            }

            // Time zones.
            var timeZonesEnabled = Convert.ToBoolean(Config.TimeZonesEnabled);

            if (timeZonesEnabled)
            {
                grpTimeZones.Visible = true;

                _timeZone1 = TimeZoneInfo.FromSerializedString(Config.TimeZone1);
                _timeZone2 = TimeZoneInfo.FromSerializedString(Config.TimeZone2);

                RefreshTimeZones();

                tmrTimeZones.Enabled = true;
                tmrTimeZones.Start();
            }
            else
            {
                grpTimeZones.Visible = false;
                tmrTimeZones.Enabled = false;
                tmrTimeZones.Stop();
            }

            // Update display to fit the height of visible group boxes.
            const short SPACE = 10;
            int height = mnuMain.Height;

            grpDaysSince.Top = height + SPACE;
            height += grpDaysSince.Top + grpDaysSince.Height + SPACE;

            if (countdownDateEnabled)
            {
                grpDateCountdown.Top = grpDaysSince.Top + grpDaysSince.Height + SPACE;
                height += SPACE + grpDateCountdown.Height;
            }

            if (timeZonesEnabled)
            {
                if (countdownDateEnabled)
                    grpTimeZones.Top = grpDateCountdown.Top + grpDateCountdown.Height + SPACE;
                else
                    grpTimeZones.Top = grpDaysSince.Top + grpDaysSince.Height + SPACE;

                height += SPACE + grpTimeZones.Height;
            }

            Height = height + (SPACE * 2);
        }

        private void RefreshTimeZones()
        {
            // Time zone 1.
            var timeZone1DateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _timeZone1);
            lblTimeZone1Date.Text = timeZone1DateTime.ToLongDateString();
            lblTimeZone1Time.Text = timeZone1DateTime.ToLongTimeString();
            lblTimeZone1City.Text = _timeZone1.DisplayName;

            // Time zone 2.
            var timeZone2DateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, _timeZone2);
            lblTimeZone2Date.Text = timeZone2DateTime.ToLongDateString();
            lblTimeZone2Time.Text = timeZone2DateTime.ToLongTimeString();
            lblTimeZone2City.Text = _timeZone2.DisplayName;
        }

        private void tmrTimeZones_Tick(object sender, EventArgs e)
        {
            RefreshTimeZones();
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowOptionsDialog()
        {
            var frmDayCounterOptions = new frmDayCounterOptions();

            frmDayCounterOptions.ShowDialog();

            RefreshOutput();
        }

        private void mnuToolsOptions_Click(object sender, EventArgs e)
        {
            ShowOptionsDialog();
        }
    }
}
