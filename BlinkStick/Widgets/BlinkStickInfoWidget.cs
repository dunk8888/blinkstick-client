﻿using System;
using BlinkStickClient.DataModel;

namespace BlinkStickClient
{
    [System.ComponentModel.ToolboxItem(true)]
    public partial class BlinkStickInfoWidget : Gtk.Bin
    {
        public BlinkStickInfoWidget()
        {
            this.Build();

            UpdateUI(null);
        }

        public void UpdateUI(BlinkStickDeviceSettings settings)
        {
            if (settings == null)
            {
                labelConnectedInfo.Text = "";
                labelSerialNumberInfo.Text = "";
                labelManufacturerInfo.Text = "";
                labelProductInfo.Text = "";
                labelModeInfo.Text = "";
            }
            else
            {
                labelConnectedInfo.Text = settings.Led != null ? "Yes" : "No";
                labelSerialNumberInfo.Text = settings.Serial;

                if (settings.Led != null)
                {
                    labelManufacturerInfo.Text = settings.Led.ManufacturerName;
                    switch (settings.Led.BlinkStickDevice)
                    {
                        case BlinkStickDotNet.BlinkStickDeviceEnum.Unknown:
                            labelProductInfo.Text = "Unknown";
                            break;
                        case BlinkStickDotNet.BlinkStickDeviceEnum.BlinkStick:
                            labelProductInfo.Text = "BlinkStick";
                            break;
                        case BlinkStickDotNet.BlinkStickDeviceEnum.BlinkStickPro:
                            labelProductInfo.Text = "BlinkStick Pro";
                            break;
                        case BlinkStickDotNet.BlinkStickDeviceEnum.BlinkStickStrip:
                            labelProductInfo.Text = "BlinkStick Strip";
                            break;
                        case BlinkStickDotNet.BlinkStickDeviceEnum.BlinkStickSquare:
                            labelProductInfo.Text = "BlinkStick Square";
                            break;
                        default:
                            break;
                    }

                    if (settings.Led.BlinkStickDevice == BlinkStickDotNet.BlinkStickDeviceEnum.BlinkStick)
                    {
                        labelModeInfo.Text = "RGB";
                    }
                    else
                    {
                        try
                        {
                            if (!settings.Led.Connected)
                            {
                                settings.Led.OpenDevice();
                            }

                            switch (settings.Led.GetMode())
                            {
                                case 0:
                                    labelModeInfo.Text = "RGB";
                                    break;
                                case 1:
                                    labelModeInfo.Text = "Inverse";
                                    break;
                                case 2:
                                    labelModeInfo.Text = "Multi-LED";
                                    break;
                                case 3:
                                    labelModeInfo.Text = "Multi-LED Mirror";
                                    break;
                                default:
                                    labelModeInfo.Text = "Unknown";
                                    break;
                            }
                        }
                        catch
                        {
                            labelModeInfo.Text = "Error";
                        }
                    }
                }
                else
                {
                    labelManufacturerInfo.Text = "";
                    labelProductInfo.Text = "";
                }
            }
        }
    }
}

