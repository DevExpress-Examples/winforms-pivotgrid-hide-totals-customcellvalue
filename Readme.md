<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/174123442/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T830448)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to Handle the CustomValueCell Event to Hide Row Totals

This example demonstrates how to use the [CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event to hide field's row totals and grand totals. When field values are collapsed, the totals remain hidden.

![screenshot](./images/screenshot.png)


API in this example:

* [PivotGridControl.CustomCellValue](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellValue) event
* [PivotGridControl.GetFieldsByArea](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.GetFieldsByArea(DevExpress.XtraPivotGrid.PivotArea)) method
* [e.RowValueType](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotCellEventArgsBase-3.RowValueType) property

**See also:**

* [Summarization - Totals](https://docs.devexpress.com/WindowsForms/1810)
* [UI Elements - Totals](https://docs.devexpress.com/WindowsForms/1691)
