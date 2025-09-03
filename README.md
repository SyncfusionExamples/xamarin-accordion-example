# Getting started with Accordion xamarin

The Accordion control allows content to be organized in a vertically stacked list of items that is collapsible. Each item can also be expanded to reveal the content associated with that item. This section provides a quick overview for working with the `SfAccordion` for Xamarin.Forms.

## Key Features 
- Animation - Supports customization of animation duration and easing.
- Different expand modes - Support to expand single or multiple items.
- Customization - Supports to customize the header icon position, space between the items and more.

## Installation
### Option 1: NuGet Package
Install `Syncfusion.Xamarin.Expander` from NuGet in all your project targets.

### Option 2: Xamarin Toolbox
Use the Syncfusion Xamarin Toolbox to drag and drop SfAccordion into your XAML page.

### Option 3: Manual Assembly Reference
Add the following assemblies manually:
- `Syncfusion.Expander.XForms.dll`
- `Syncfusion.Core.XForms.dll`
- `Syncfusion.Licensing.dll`

## Platform Initialization
### iOS
Call `SfAccordionRenderer.Init()` in `AppDelegate.FinishedLaunching`.

## XAML Usage
```xml
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:syncfusion="clr-namespace:Syncfusion.XForms.Accordion;assembly=Syncfusion.Expander.XForms">
    <ContentPage.Content>
        <syncfusion:SfAccordion>
            <syncfusion:SfAccordion.Items>
                <syncfusion:AccordionItem>
                    <syncfusion:AccordionItem.Header>
                        <Grid>
                            <Label Text="Cheese burger" />
                        </Grid>
                    </syncfusion:AccordionItem.Header>
                    <syncfusion:AccordionItem.Content>
                        <Grid>
                            <Label Text="Hamburger with melted cheese." />
                        </Grid>
                    </syncfusion:AccordionItem.Content>
                </syncfusion:AccordionItem>
            </syncfusion:SfAccordion.Items>
        </syncfusion:SfAccordion>
    </ContentPage.Content>
</ContentPage>
```