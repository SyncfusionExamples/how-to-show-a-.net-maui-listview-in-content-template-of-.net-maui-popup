# how-to-show-a-.net-maui-listview-in-content-template-of-.net-maui-popup

This examples shows how to show a .NET Maui ListView in content template of .NET Maui SfPopup

```
   <sfPopup:SfPopup x:Name="sfPopup" 
                             HeaderTitle="ListView"
                             ShowFooter="True"
                             HeightRequest="300" WidthRequest="300">
                <sfPopup:SfPopup.ContentTemplate>
                    <DataTemplate>
                        <sfListView:SfListView x:Name="listView" ItemSize="46"
                                               ItemsSource="{Binding Items}">

                            <sfListView:SfListView.ItemTemplate>
                                <DataTemplate>
                                    <Grid x:Name="grid">
                                        <Grid.ColumnDefinitions>
                                            <ColumnDefinition Width="46" />
                                            <ColumnDefinition Width="*" />
                                            <ColumnDefinition Width="*" />
                                        </Grid.ColumnDefinitions>

                                        <Image Source="{Binding ContactImage}"
                                               VerticalOptions="Center"
                                               HorizontalOptions="Center"
                                               HeightRequest="30"
                                               WidthRequest="30"/>

                                        <Label Grid.Column="1"
                                               VerticalTextAlignment="Center"
                                               LineBreakMode="NoWrap"
                                               Text="{Binding ContactName}" 
                                               FontSize="14" FontFamily="Roboto"/>

                                        <Image Grid.Column="2" 
                                               Source="phoneimage.png"
                                               VerticalOptions="Center"
                                               HorizontalOptions="End"
                                               HeightRequest="15"
                                               WidthRequest="15" Margin="0,0,8,0"/>
                                    </Grid>
                                </DataTemplate>
                            </sfListView:SfListView.ItemTemplate>
                        </sfListView:SfListView>
                    </DataTemplate>
                </sfPopup:SfPopup.ContentTemplate>
            </sfPopup:SfPopup>
```
## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/)
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.