using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class frmDayCounterOptions : Form
    {
        private ReadOnlyCollection<TimeZoneInfo> _timeZones;
        private string[] _timeZoneDisplayStrings;

        public frmDayCounterOptions()
        {
            InitializeComponent();

            _timeZones = TimeZoneInfo.GetSystemTimeZones();
            _timeZoneDisplayStrings = new string[_timeZones.Count - 1];

            // Initialize time zone list.
            for (int i = 0; i < _timeZoneDisplayStrings.Length; i++)
                _timeZoneDisplayStrings[i] = _timeZones.ElementAt(i).DisplayName;
        }

        private void frmDayCounterOptions_Load(object sender, EventArgs e)
        {
            // Set max days for date since.
            dtpSinceDate.MaxDate = DateTime.Now;

            // Set min days for countdown.
            dtpCountdownDate.MinDate = DateTime.Now;

            // Set local time zone default.
            var localTimeZoneIndex = Array.IndexOf(_timeZoneDisplayStrings, TimeZoneInfo.Local.ToString());

            cboTimezone1.Items.AddRange(_timeZoneDisplayStrings);
            cboTimezone2.Items.AddRange(_timeZoneDisplayStrings);

            // Set default values and restore values from config if they are set.
            if (!String.IsNullOrWhiteSpace(Config.SinceDate)
                    && (Convert.ToDateTime(Config.SinceDate) < dtpSinceDate.MaxDate))
                dtpSinceDate.Value = Convert.ToDateTime(Config.SinceDate);

            if (!String.IsNullOrWhiteSpace(Config.CountdownDate)
                    && (Convert.ToDateTime(Config.CountdownDate) > dtpCountdownDate.MinDate))
                dtpCountdownDate.Value = Convert.ToDateTime(Config.CountdownDate);

            if (!String.IsNullOrWhiteSpace(Config.CountdownDateEnabled))
                dtpCountdownDate.Checked = Convert.ToBoolean(Config.CountdownDateEnabled);

            if (!String.IsNullOrWhiteSpace(Config.TimeZonesEnabled))
                chkShowTimeZones.Checked = Convert.ToBoolean(Config.TimeZonesEnabled);

            cboTimezone1.SelectedIndex = localTimeZoneIndex;
            cboTimezone2.SelectedIndex = localTimeZoneIndex;

            if (!String.IsNullOrWhiteSpace(Config.TimeZone1))
                cboTimezone1.SelectedIndex = Array.IndexOf(_timeZoneDisplayStrings, _timeZones.Single(t => t.ToSerializedString() == Config.TimeZone1).DisplayName);

            if (!String.IsNullOrWhiteSpace(Config.TimeZone2))
                cboTimezone2.SelectedIndex = Array.IndexOf(_timeZoneDisplayStrings, _timeZones.Single(t => t.ToSerializedString() == Config.TimeZone2).DisplayName);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // If not settings are saved, then just close the entire application.
            if (String.IsNullOrWhiteSpace(Config.SinceDate))
                Environment.Exit(0);

            Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Save settings.
            Config.SinceDate = dtpSinceDate.Value.ToString("yyyy-MM-dd");
            Config.CountdownDateEnabled = dtpCountdownDate.Checked.ToString();
            Config.CountdownDate = dtpCountdownDate.Value.ToString("yyyy-MM-dd");
            Config.TimeZonesEnabled = chkShowTimeZones.Checked.ToString();
            Config.TimeZone1 = _timeZones.Single(t => t.ToString() == cboTimezone1.SelectedItem.ToString()).ToSerializedString();
            Config.TimeZone2 = _timeZones.Single(t => t.ToString() == cboTimezone2.SelectedItem.ToString()).ToSerializedString();

            Dispose();
        }
    }
}
