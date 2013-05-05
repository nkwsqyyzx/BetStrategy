<DockPanel VerticalAlignment="Stretch">

        <ListView 
          DockPanel.Dock="Top"
          HorizontalContentAlignment="Stretch"
          x:Name="MyListView">
        <ListView.Resources>
            <Style TargetType="ListViewItem">
                <Setter Property="HorizontalContentAlignment" Value="Center" />
            </Style>

        </ListView.Resources>
            <ListView.View>
                <GridView >

                    <GridViewColumn Width="Auto"
                            DisplayMemberBinding="{Binding Name}"
                            Header="Name" />

                    <GridViewColumn Width="Auto" Header="Type">

                        <GridViewColumn.CellTemplate>
                            <DataTemplate>
                                <TextBlock Text="{Binding Type}" HorizontalAlignment="Center"  TextAlignment="Center" />
                            </DataTemplate>
                        </GridViewColumn.CellTemplate>
                    </GridViewColumn>

                </GridView>
            </ListView.View>
        </ListView>

        <DockPanel Width="100"
           Height="100"
           Margin="0,0,20,20"
           HorizontalAlignment="Right"
           VerticalAlignment="Bottom">

            <Label Margin="0,0,0,0"
           Content="Data"
           DockPanel.Dock="Top" />

            <ListBox
             VerticalAlignment="Top"/>

        </DockPanel>

</DockPanel>
